
            Console.WriteLine("Ingrese el ancho del lote en metros:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del lote en metros:");
            double largo = Convert.ToDouble(Console.ReadLine());

            double precioPorMetroCuadrado = 10;     

            double area = ancho * largo;

            double precioTotal = area * precioPorMetroCuadrado;

            Console.WriteLine($"El área del lote es: {area} metros cuadrados.");
            Console.WriteLine($"El precio total del lote es: ${precioTotal}");


