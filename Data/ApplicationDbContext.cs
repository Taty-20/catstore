using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using catstore.Models;//agregar

namespace catstore.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


    public DbSet<Contacto> DataContactos { get;set;} //AGREGAR para que la bd se guarde el dato del formulario contacto y se visualice en t_contacto

    public DbSet<Producto> DataProductos { get;set;} //AGREGAR PARA INICIAR LA MIGRACION t_producto
}
