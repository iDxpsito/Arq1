# ==========================================
# ACTIVIDAD: Completa el programa
# Usando arquitectura llamar y regresar
# ==========================================
 
def main():
    print("=== SISTEMA DE COMPRA ===")
 
    producto = pedir_producto()
    precio = obtener_precio(producto)
    total = calcular_total(precio)
    mostrar_total(producto,total)
 
 
def pedir_producto():
    # TODO: pedir el nombre del producto y regresarlo
    nombre = input("INgrese el producto: ")
    return nombre
 
 
def obtener_precio(producto):
    print(producto)
    return 1000
 
 
def calcular_total(precio):
    iva = precio * 0.21
    total = precio + iva
    return total
 
def mostrar_total(producto, total):
    print(f"El total a pagar de {producto} es de: {total}")
 
 
main()
 