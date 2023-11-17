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
columns = ('RepTheme', 'ScFIO', 'ScDeg', 'ScCountry', 'ScOrg', 'ConfName', 'ConfDate', 'ConfCountry')
tw_reports = ttk.Treeview(frame_tw, columns=columns, show="headings")
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

btn_reports = ttk.Button(frame_bottom, text='Обновить', command=update)
btn_reports.pack()

btn_add_report = ttk.Button(frame_bottom, text='Добавить доклад', command=add_report)
btn_add_report.pack()

frame_bottom.pack(side=BOTTOM, fill=X)

frame_main.pack(fill=Y)

page.mainloop()
