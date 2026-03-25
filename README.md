# EXAMEN-SEGUNDO-PROG

Sistema de Gestión de Inventario Descripción General: El sistema permite gestionar diferentes tipos de productos (Electrónicos y Alimentos) que comparten características comunes pero en el impuesto tienen comportamientos específicos por eso usamos las herencias, especialmente en el cálculo de impuestos y atributos adicionales.

Estructura del Código: El proyecto utiliza una jerarquía de clases para organizar la información:

Clase Base: ProductoContiene las propiedades generales que cualquier artículo del inventario posee:Atributos: Nombre, Código, Precio y Cantidad.Métodos: * MostrarProducto(): Imprime los detalles básicos en consola.CalcularImpuesto(): Un método virtual que devuelve 0 por defecto.

Clases Derivadas (Herencia)ProductoElectronico:Añade el atributo GarantiaMeses.Polimorfismo: Invalida (override) el cálculo de impuesto para aplicar un 18%.ProductoAlimento:Añade el atributo FechaVencimiento.Polimorfismo: Invalida (override) el cálculo de impuesto para aplicar un 8%.

Ejemplo de EjecuciónAl ejecutar el programa, en el Main instancie dos objetos de ejemplo para demostrar el funcionamiento que fuerom: Laptop: Se muestra su información y se calcula el impuesto basado en el precio de $25,000.Saldinas: Se muestra su información, incluyendo la fecha de vencimiento, y se calcula su impuesto reducido.Nota: El código utiliza el formato de moneda (:C) para una visualización más limpia de los precios y resultados.

# # Estudiante: Lucero Maria Liz Lazar Mejia.

<img width="1366" height="768" alt="Captura de pantalla (33)" src="https://github.com/user-attachments/assets/135f1c1a-faf3-499c-ad0e-b01cd6a0bbcf" />
