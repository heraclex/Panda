using PandaBookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Data
{
    public class StoreContextSeedData
    {
        private StoreContext context;
        public StoreContextSeedData(StoreContext context)
        {
            this.context = context;
        }

        public async Task EnsureSeedData(string bookImageFolder)
        {
            this.context.Database.EnsureCreated();
            await this.CreateCategories();
            await this.CreateRoles();
            await this.CreateCustomers();
            await this.CreateBooks(bookImageFolder);
        }

        #region private methods

        private async Task CreateCategories()
        {
            if (!this.context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category {CategoryName="Business", CreatedDate = DateTime.Now },
                    new Category {CategoryName="Cookery", CreatedDate = DateTime.Now},
                    new Category {CategoryName="Fiction", CreatedDate = DateTime.Now},
                    new Category {CategoryName="Non Fiction", CreatedDate = DateTime.Now},
                    new Category {CategoryName="Leisure", CreatedDate = DateTime.Now},
                    new Category {CategoryName="Travel", CreatedDate = DateTime.Now},
                    new Category {CategoryName="Spritual", CreatedDate = DateTime.Now}
                };

                categories.ForEach(c => context.Categories.Add(c));
                await this.context.SaveChangesAsync();
            }
        }

        private async Task CreateRoles()
        {
            if (!this.context.Roles.Any())
            {
                var roles = new List<Role>
                {
                    new Role {RoleName="SysAdmin", CreatedDate = DateTime.Now},
                    new Role {RoleName="Admin", CreatedDate = DateTime.Now},
                    new Role {RoleName="User", CreatedDate = DateTime.Now},
                };

                roles.ForEach(r => context.Roles.Add(r));

                await this.context.SaveChangesAsync();
            }
        }

        private async Task CreateCustomers()
        {
            if (!this.context.Customers.Any())
            {
                var customers = new List<Customer>
            {
                new Customer {
                    UserName="helen.nguyen",
                    Password="123456",
                    FirstName ="Hellen",
                    LastName ="Nguyen",
                    Address ="123 Queen Str",
                    Surburb ="CBD",
                    City ="Auckland",
                    Zipcode = "NZ",
                    EmailAddress ="ntthanhthao@outlook.com",
                    PhoneNumber="+64 229009000",
                    HearUs= "Website",
                    HowContactYou="Phone",
                    Subscribe=false,
                    Active = true,
                    //CreditCardNumber="123....90",
                    //CardExpiredDate="12/20",
                    RoleId = 1, CreatedDate = DateTime.Now

                },

                new Customer {
                    UserName="tiana.mohemet",
                    Password="123456",
                    FirstName ="tiana",
                    LastName ="mohemet",
                    Address ="456 Queen Str",
                    Surburb ="CBD",
                    City ="Auckland",
                    Zipcode = "NZ",
                    EmailAddress ="tiana.mohemet@outlook.com",
                    PhoneNumber="+64 2290099999",
                    Subscribe=false,
                    Active = true,
                    //CreditCardNumber="333....90",
                    //CardExpiredDate="12/20",
                    RoleId = 1, CreatedDate = DateTime.Now
                },

                new Customer {
                    UserName="linda.ran",
                    Password="123456",
                    FirstName ="Linda",
                    LastName ="ran",
                    Address ="789 Queen Str",
                    Surburb ="CBD",
                    City ="Auckland",
                    Zipcode = "NZ",
                    EmailAddress ="linda.ran@outlook.com",
                    PhoneNumber="+64 22900991239",
                    Subscribe=false,
                    Active = true,
                    //CreditCardNumber="9999....99",
                    //CardExpiredDate="12/20",
                    RoleId = 1, CreatedDate = DateTime.Now
                },
            };

                customers.ForEach(c => context.Customers.Add(c));

                await this.context.SaveChangesAsync();
            }
        }

        private async Task CreateBooks(string bookImageFolder)
        {
            if (!this.context.Books.Any())
            {
                DirectoryInfo directory = new DirectoryInfo(bookImageFolder);
                FileInfo[] Files = directory.GetFiles("*.png"); //Getting Png files
                Random random = new Random();
                foreach (FileInfo file in Files)
                {
                    using (var stream = file.OpenRead())
                    {
                        using (var binary = new BinaryReader(stream))
                        {
                            var imgData = binary.ReadBytes((int)stream.Length);
                            var pic = new Picture()
                            {
                                PictureBinary = imgData
                            };
                            var book = new Book()
                            {
                                BookName = file.Name.Replace(".png", string.Empty),
                                AuthorName = "Author" + file.Name.Replace(".png", string.Empty),
                                CreatedDate = DateTime.Now,
                                Picture = pic,
                                PublishedYear = random.Next(2000, 2018).ToString(), // Random year: >= 1990 and < 2018
                                CategoryId = random.Next(1, 8), // Random CategoryId: >= 1 and < 8
                                Price = random.Next(20, 60), // Random price: >= 1 and < 60
                                Quantity = random.Next(1, 50), // Random QuantityInUnit: >= 1 and < 50
                                Description = "Description for" + file.Name.Replace(".png", string.Empty),
                                Publisher = "Publisher Test",
                                IsDelete = false,
                                NewRelease = false,
                                Rate = 5
                            };
                            context.Books.Add(book);
                        }
                    }
                }

                await this.context.SaveChangesAsync();
            }            
        }

        #endregion
    }
}
