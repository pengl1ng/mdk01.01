import tkinter
from tkinter import *
from tkinter import ttk
from DBConnect import Reports


tab_reports = Reports()


def update():
    for elem in tw_reports.get_children(""):
        tw_reports.delete(elem)

    for rep in tab_reports.view_reports():
        tw_reports.insert("", index=END, values=rep)


def add_report():
    theme = str(rep_theme.get())
    author = int(rep_author.get())
    conf = int(rep_conf.get())
    tab_reports.create_report(theme, author, conf)
    update()


def del_report():
    for selected_item in tw_reports.selection():
        item = tw_reports.item(selected_item)
        rep = item["values"]
        tab_reports.delete_report(int(rep[0]))
        update()


def tree_item_select():
    item = tw_reports.item(tw_reports.selection()[0])
    rep = item["values"]
    rep_theme.delete(0, END)
    rep_author.delete(0, END)
    rep_conf.delete(0, END)
    rep_theme.insert(END, rep[1])
    rep_author.insert(END, rep[2])
    rep_conf.insert(END, rep[3])


page = Tk()
page.title("Работы ученых")
page.geometry("800x500")

# Главный контейнер
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
rep_author = ttk.Entry(frame_author, width=30)
rep_author.pack(anchor=CENTER)
frame_author.pack(anchor=CENTER)

frame_conf = ttk.Frame(frame_left, padding=5)
ttk.Label(frame_conf, text="Название конференции", justify=CENTER).pack()
rep_conf = ttk.Entry(frame_conf, width=30)
rep_conf.pack(anchor=CENTER)
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
frame_tw.pack(side=RIGHT, anchor=N)
frame_top.pack(fill=X)

# Нижний контейнер
frame_bottom = ttk.Frame(frame_main, padding=5)

btn_add_report = ttk.Button(frame_bottom, padding=5, text='Добавить доклад', command=add_report)
btn_add_report.grid(row=0, column=0, columnspan=2)

btn_del_report = ttk.Button(frame_bottom, padding=5, text='Удалить доклад', command=del_report)
btn_del_report.grid(row=0, column=2, columnspan=2)

frame_bottom.pack(side=LEFT, fill=X)

frame_main.pack(fill=Y)

update()
page.mainloop()
