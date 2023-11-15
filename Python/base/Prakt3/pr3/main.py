from tkinter import *


def save():
    f = open('text.txt', 'w')
    f.writelines("\n".join(res_listbox.get(0, END)))
    f.close()


def calc():
    res_listbox.insert(0, "Работу выполнил ст. Самозванцев В.А.")
    x0 = float(xEnt.get())
    xk = float(xkEnt.get())
    dx = float(dxEnt.get())
    b = float(bEnt.get())
    while x0 <= xk:
        y = 0.8 * 10**-5 * (x0**3 + b**3)**(7/6)
        res_listbox.insert(END, f"x={round(x0, 2)}; y={y}")
        x0 += dx


root = Tk()
root.title("ПР3 Самозванцев, Вариант 8")
root.geometry("300x500")

Label(text="x0=", width=10).grid(column=0, row=0, padx=10, pady=10)
xEnt = Entry(width=20)
xEnt.grid(column=1, row=0, padx=10, pady=10)

Label(text="xk=", width=10).grid(column=0, row=1, padx=10, pady=10)
xkEnt = Entry(width=20)
xkEnt.grid(column=1, row=1, padx=10, pady=10)

Label(text="dx=", width=10).grid(column=0, row=2, padx=10, pady=10)
dxEnt = Entry(width=20)
dxEnt.grid(column=1, row=2, padx=10, pady=10)

Label(text="b=", width=10).grid(column=0, row=3, padx=10, pady=10)
bEnt = Entry(width=20)
bEnt.grid(column=1, row=3, padx=10, pady=10)

res_listbox = Listbox(width=40)
res_listbox.grid(column=0, columnspan=3, row=4, padx=10, pady=10)

Button(text="Результат", command=calc).grid(column=0, columnspan=2, row=5, padx=10, pady=10)
Button(text="Сохранить в файл", command=save).grid(column=0, columnspan=5, padx=10, pady=10)
root.mainloop()