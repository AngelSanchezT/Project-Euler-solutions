def solution(n):
    list_num = [num for num in range(n) if (num % 3 == 0) or (num % 5 == 0)]
    return sum(list_num)

n = int(input("Escribe el limite de los numeros a evaluar:"))
sum = solution(n)
print('La sumatoria de los multiplos de 3 y 5 por debajo de ' + str(n) + ' es: ' + str(sum))
