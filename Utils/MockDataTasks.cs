using csharp_dotnetcore_projects.Models;
using System.Collections.Generic;

namespace csharp_dotnetcore_projects.Utils
{

    public class MockDataTasks
    {
        private ApplicationDbContext context;


        public MockDataTasks(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void SetData()
        {
            context.Tasks.AddRange(new List<Task>() {
                new Task(){
                   Name = "Escribir Documentacion",
                   Description = "Escribir Documentacion",
                   State = "In-Progress",
                   Owner = "Goku",
                   CreatedDate = "27-05-2019"
                },
                new Task(){
                   Name = "Realizar Presupuestos",
                   Description = "Realizar Presupuestos",
                   State = "In-Progress",
                   Owner = "Vegeta",
                   CreatedDate = "01-01-2020"
                },
                new Task(){
                   Name = "Realizar Compra de Material",
                   Description = "Realizar Compra de Material",
                   State = "In-Progress",
                   Owner = "Gohan",
                   CreatedDate = "01-01-2020"
                },
                new Task(){
                   Name = "Realizar Investigacion",
                   Description = "Realizar Investigacion",
                   State = "In-Progress",
                   Owner = "Piccolo",
                   CreatedDate = "01-01-2020"
                },
                new Task(){
                   Name = "Realizar Nominas",
                   Description = "Realizar Nominas",
                   State = "In-Progress",
                   Owner = "Vegetto",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Cumplimiento de las normativas",
                   Description = "Cumplimiento de las normativas",
                   State = "In-Progress",
                   Owner = "Gogeta",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Control de obras",
                   Description = "Control de obras",
                   State = "In-Progress",
                   Owner = "Trunks",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Control de policial",
                   Description = "Control de policial",
                   State = "In-Progress",
                   Owner = "Trunks",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Control Impuestos",
                   Description = "Control de Impuestos",
                   State = "In-Progress",
                   Owner = "Broly",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Venta panfletos",
                   Description = "Venta panfletos",
                   State = "In-Progress",
                   Owner = "Freezer",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Reparticion de boletas",
                   Description = "Reparticion de boletas",
                   State = "Todo",
                   Owner = "Bulma",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Reparticion de víveres",
                   Description = "Reparticion de víveres",
                   State = "Testing",
                   Owner = "Krilin ",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Control de calidad",
                   Description = "Control de calidad",
                   State = "Closed",
                   Owner = "Majin Buu",
                   CreatedDate = "28-02-2020"
                },
                new Task(){
                   Name = "Control de aduanas",
                   Description = "Control de aduanas",
                   State = "Closed",
                   Owner = "Mr. Popo",
                   CreatedDate = "28-02-2020"
                }
            });
            context.SaveChanges();
        }
    }
}
