import tkinter
from tkinter import *
from tkinter import ttk
from tkcalendar import dateentry
from DBConnect import *


tab_reports = Reports()
tab_confs = Conferences()
tab_sci = Scientists()


def update_scis():
    for elem in tw_sci.get_children(""):
        tw_sci.delete(elem)

    for sci in tab_sci.view_scientists():
        tw_sci.insert("", index=END, values=sci)


def update_confs():
    for elem in tw_confs.get_children(""):
        tw_confs.delete(elem)

    for conf in tab_confs.view_conferences():
        tw_confs.insert("", index=END, values=conf)


def update_reports():
    for elem in tw_reports.get_children(""):
        tw_reports.delete(elem)

    for rep in tab_reports.view_reports():
        tw_reports.insert("", index=END, values=rep)


def add_report():
    theme = str(rep_theme.get())
    author = int(tab_sci.find_sci_id(cbox_sci.get()))
    conf = int(tab_confs.find_conf_id(cbox_conf.get()))
    tab_reports.create_report(theme, author, conf)
    update_reports()


def add_conf():
    name = str(conf_name.get())
    date = str(conf_date.get())
    country = str(conf_country.get())
    tab_confs.create_conference(name, date, country)
    update_confs()


def add_sci():
    fio = str(sci_fio.get())
    deg = str(sci_deg.get())
    country = str(sci_country.get())
    org = str(sci_org.get())
    tab_sci.create_scientist(fio, deg, country, org)
    update_scis()


def del_sci():
    for selected_item in tw_sci.selection():
        item = tw_sci.item(selected_item)
        sci = item["values"]
        tab_sci.delete_scientist(int(sci[0]))
        update_reports()


def del_report():
    for selected_item in tw_reports.selection():
        item = tw_reports.item(selected_item)
        rep = item["values"]
        tab_reports.delete_report(int(rep[0]))
        update_reports()


def del_conf():
    for selected_item in tw_confs.selection():
        item = tw_confs.item(selected_item)
        con = item["values"]
        tab_confs.delete_conference(int(con[0]))
        update_confs()


def update_sci():
    fio = str(sci_fio.get())
    deg = str(sci_deg.get())
    country = str(sci_country.get())
    org = str(sci_org.get())
    if tw_sci.selection() != ():
        item = tw_sci.item(tw_sci.selection()[0])
        sci = item["values"]
        sc_id = sci[0]
        tab_sci.update_scientists(sc_id, fio, deg, country, org)
        update_scis()


def update_rep():
    theme = str(rep_theme.get())
    author = int(tab_sci.find_sci_id(cbox_sci.get()))
    conf = int(tab_confs.find_conf_id(cbox_conf.get()))
    if tw_reports.selection() != ():
        item = tw_reports.item(tw_reports.selection()[0])
        rep = item["values"]
        rep_id = rep[0]
        tab_confs.update_conference(rep_id, theme, author, conf)
        update_reports()


def update_conf():
    name = str(conf_name.get())
    date = str(conf_date.get())
    country = str(conf_country.get())
    if tw_confs.selection() != ():
        item = tw_confs.item(tw_confs.selection()[0])
        conf = item["values"]
        conf_id = conf[0]
        tab_confs.update_conference(conf_id, name, date, country)
        update_confs()


def tree_sci_item_select(event):
    if tw_sci.selection() != ():
        item = tw_sci.item(tw_sci.selection()[0])
        sci = item["values"]
        sci_fio.delete(0, END)
        sci_deg.delete(0, END)
        sci_country.delete(0, END)
        sci_org.delete(0, END)
        sci_fio.insert(END, sci[1])
        sci_deg.insert(END, sci[2])
        sci_country.insert(END, sci[3])
        sci_org.insert(END, sci[4])


def tree_conf_item_select(event):
    if tw_confs.selection() != ():
        item = tw_confs.item(tw_confs.selection()[0])
        conf = item["values"]
        conf_name.delete(0, END)
        conf_country.delete(0, END)
        conf_name.insert(END, conf[1])
        conf_date.set_date(conf[2])
        conf_country.insert(END, conf[3])


def tree_rep_item_select(event):
    if tw_reports.selection() != ():
        item = tw_reports.item(tw_reports.selection()[0])
        rep = item["values"]
        rep_theme.delete(0, END)
        rep_theme.insert(END, rep[1])
        cbox_sci.current(int(rep[2]) - 1)
        cbox_conf.current(int(rep[3]) - 1)


page = Tk()
page.title("Работы ученых")
page.geometry("800x500")

notebook = ttk.Notebook()
notebook.pack(expand=True, fill=BOTH, anchor=N)
# Доклады
frame_main = ttk.Frame(page, padding=5)
# Верхний контейнер
frame_top = ttk.Frame(frame_main, padding=5)
# Левый контейнер (там где поля)
frame_left = ttk.Frame(frame_top, padding=5)
frame_theme = ttk.Frame(frame_left, padding=5)
ttk.Label(frame_theme, text="Название доклада", justify=CENTER).pack()
rep_theme = ttk.Entry(frame_theme, width=30)
rep_theme.pack(anchor=CENTER)
frame_theme.pack(anchor=CENTER)
frame_author = ttk.Frame(frame_left, padding=5)
ttk.Label(frame_author, text="ФИО докладчика", justify=CENTER).pack()
cbox_sci = ttk.Combobox(frame_author, values=tab_sci.select_sci_fios())
cbox_sci.pack()
frame_author.pack(anchor=CENTER)
frame_conf = ttk.Frame(frame_left, padding=5)
ttk.Label(frame_conf, text="Название конференции", justify=CENTER).pack()
cbox_conf = ttk.Combobox(frame_conf, values=tab_confs.select_confs_names())
cbox_conf.pack()
frame_conf.pack(anchor=CENTER)
frame_left.pack(side=LEFT, anchor=N)
# Treeview
frame_tw = ttk.Frame(frame_top, padding=5)
columns = ('RepId', 'RepTheme', 'RepAuthor', 'RepConf', 'ScFIO', 'ScDeg', 'ScCountry',
           'ScOrg', 'ConfName', 'ConfDate', 'ConfCountry')
display_col = ('RepTheme', 'ScFIO', 'ScDeg', 'ScCountry', 'ScOrg', 'ConfName', 'ConfDate', 'ConfCountry')
tw_reports = ttk.Treeview(frame_tw, columns=columns, displaycolumns=display_col, show="headings")
tw_reports.pack()
tw_reports.heading('RepTheme', text='Тема доклада')
tw_reports.heading('ScFIO', text='ФИО')
tw_reports.heading('ScDeg', text='Степень')
tw_reports.heading('ScCountry', text='Страна')
tw_reports.heading('ScOrg', text='Организация')
tw_reports.heading('ConfName', text='Название конференции')
tw_reports.heading('ConfDate', text='Дата')
tw_reports.heading('ConfCountry', text='Страна конференции')
scrollbar = ttk.Scrollbar(frame_tw, orient=tkinter.HORIZONTAL, command=tw_reports.xview)
scrollbar.pack(fill=X, side=BOTTOM)
tw_reports.configure(xscrollcommand=scrollbar.set)
tw_reports.bind("<<TreeviewSelect>>", tree_rep_item_select)
frame_tw.pack(side=RIGHT, anchor=N)
frame_top.pack(fill=X)
# Нижний контейнер
frame_btns = ttk.Frame(frame_main, padding=5)
btn_add_report = ttk.Button(frame_btns, padding=5, text='Добавить доклад', command=add_report)
btn_add_report.grid(row=0, column=0, columnspan=2)
btn_del_report = ttk.Button(frame_btns, padding=5, text='Удалить доклад', command=del_report)
btn_del_report.grid(row=0, column=2, columnspan=2)
btn_update_report = ttk.Button(frame_btns, padding=5, text='Обновить доклад', command=update_rep)
btn_update_report.grid(row=0, column=4, columnspan=2)
frame_btns.pack(side=LEFT, fill=X)
frame_main.pack(fill=Y)

# Конференции
conf_frame = ttk.Frame(padding=5)
frame_up = ttk.Frame(conf_frame, padding=5)
frame_text = ttk.Frame(frame_up, padding=5)
frame_name = ttk.Frame(frame_text, padding=5)
ttk.Label(frame_name, text="Название конференции", justify=CENTER).pack()
conf_name = ttk.Entry(frame_name, width=30)
conf_name.pack(anchor=CENTER)
frame_name.pack(anchor=CENTER)
frame_date = ttk.Frame(frame_text, padding=5)
ttk.Label(frame_date, text="Дата конференции", justify=CENTER).pack()
conf_date = dateentry.DateEntry(frame_date, selectmode='day')
conf_date.pack(anchor=CENTER)
frame_date.pack(anchor=CENTER)
frame_country = ttk.Frame(frame_text, padding=5)
ttk.Label(frame_country, text="Страна конференции", justify=CENTER).pack()
conf_country = ttk.Entry(frame_country, width=30)
conf_country.pack(anchor=CENTER)
frame_country.pack(anchor=CENTER)
frame_text.pack(side=LEFT, anchor=N)

frame_tw_conf = ttk.Frame(frame_up, padding=5)
column = ('ConfId', 'ConfName', 'ConfDate', 'ConfCountry')
disp_col = ('ConfName', 'ConfDate', 'ConfCountry')
tw_confs = ttk.Treeview(frame_tw_conf, columns=column, displaycolumns=disp_col, show="headings")
tw_confs.pack()
tw_confs.heading('ConfName', text='Название конференции')
tw_confs.heading('ConfDate', text='Дата конференции')
tw_confs.heading('ConfCountry', text='Страна')
tw_confs.bind("<<TreeviewSelect>>", tree_conf_item_select)
frame_tw_conf.pack(side=RIGHT, anchor=N)
frame_up.pack(fill=X)

frame_btns = ttk.Frame(conf_frame, padding=5)
btn_add_conf = ttk.Button(frame_btns, padding=5, text='Добавить конференцию', command=add_conf)
btn_add_conf.grid(row=0, column=0, columnspan=2)
btn_del_conf = ttk.Button(frame_btns, padding=5, text='Удалить конференцию', command=del_conf)
btn_del_conf.grid(row=0, column=2, columnspan=2)
btn_update_conf = ttk.Button(frame_btns, padding=5, text='Обновить конференцию', command=update_conf)
btn_update_conf.grid(row=0, column=4, columnspan=2)
frame_btns.pack(side=LEFT, fill=X)
conf_frame.pack(fill=Y)

# Ученые
frame_sci = ttk.Frame(padding=5)
top_frame = ttk.Frame(frame_sci, padding=5)
text_frame = ttk.Frame(top_frame, padding=5)
frame_fio = ttk.Frame(text_frame, padding=5)
ttk.Label(frame_fio, text="ФИО ученого", justify=CENTER).pack()
sci_fio = ttk.Entry(frame_fio, width=30)
sci_fio.pack(anchor=CENTER)
frame_fio.pack(anchor=CENTER)
frame_deg = ttk.Frame(text_frame, padding=5)
ttk.Label(frame_deg, text="Степень ученого", justify=CENTER).pack()
sci_deg = ttk.Entry(frame_deg, width=30)
sci_deg.pack(anchor=CENTER)
frame_deg.pack(anchor=CENTER)
frame_count = ttk.Frame(text_frame, padding=5)
ttk.Label(frame_count, text="Страна", justify=CENTER).pack()
sci_country = ttk.Entry(frame_count, width=30)
sci_country.pack(anchor=CENTER)
frame_count.pack(anchor=CENTER)
frame_org = ttk.Frame(text_frame, padding=5)
ttk.Label(frame_org, text="Организация", justify=CENTER).pack()
sci_org = ttk.Entry(frame_org, width=30)
sci_org.pack(anchor=CENTER)
frame_org.pack(anchor=CENTER)
text_frame.pack(side=LEFT, anchor=N)

frame_tw_sci = ttk.Frame(top_frame, padding=5)
colums = ('ScId', 'ScFIO', 'ScDeg', 'ScCountry', 'ScOrg')
displ_col = ('ScFIO', 'ScDeg', 'ScCountry', 'ScOrg')
tw_sci = ttk.Treeview(frame_tw_sci, columns=colums, displaycolumns=displ_col, show="headings")
tw_sci.pack()
tw_sci.heading('ScFIO', text='ФИО')
tw_sci.heading('ScDeg', text='Степень')
tw_sci.heading('ScCountry', text='Страна')
tw_sci.heading('ScOrg', text='Организация')
scbar = ttk.Scrollbar(frame_tw_sci, orient=tkinter.HORIZONTAL, command=tw_sci.xview)
scbar.pack(fill=X, side=BOTTOM)
tw_sci.configure(xscrollcommand=scrollbar.set)
tw_sci.bind("<<TreeviewSelect>>", tree_sci_item_select)
frame_tw_sci.pack(side=RIGHT, anchor=N)
top_frame.pack(fill=X)

bot_frame = ttk.Frame(frame_sci, padding=5)
btn_add_sci = ttk.Button(bot_frame, padding=5, text='Добавить ученого', command=add_sci)
btn_add_sci.grid(row=0, column=0, columnspan=2)
btn_del_sci = ttk.Button(bot_frame, padding=5, text='Удалить ученого', command=del_sci)
btn_del_sci.grid(row=0, column=2, columnspan=2)
btn_update_sci = ttk.Button(bot_frame, padding=5, text='Обновить ученого', command=update_sci)
btn_update_sci.grid(row=0, column=4, columnspan=2)
bot_frame.pack(side=LEFT, fill=X)
frame_sci.pack(fill=Y)

notebook.add(frame_main, text="Доклады")
notebook.add(conf_frame, text="Конференции")
notebook.add(frame_sci, text="Ученые")
update_scis()
update_reports()
update_confs()
page.mainloop()
