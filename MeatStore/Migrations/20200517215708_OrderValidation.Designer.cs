﻿// <auto-generated />
using System;
using MeatStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeatStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200517215708_OrderValidation")]
    partial class OrderValidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeatStore.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Beef",
                            Description = "All Cow meats"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Pork",
                            Description = "All Pork meats"
                        });
                });

            modelBuilder.Entity("MeatStore.Data.Models.Meat", b =>
                {
                    b.Property<int>("MeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<bool>("IsPreferredMeat")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeatId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Meats");

                    b.HasData(
                        new
                        {
                            MeatId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/beef%2520%2528raw%2529.jpg",
                            ImageUrl = "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/beef%2520%2528raw%2529.jpg",
                            InStock = 10,
                            IsPreferredMeat = true,
                            LongDescription = "Beef is the culinary name for meat from cattle, particularly skeletal muscle. Humans have been eating beef since prehistoric times. Beef is a source of high-quality protein and nutrients.",
                            Name = "beef",
                            Price = 7.95m,
                            ShortDescription = "The most widely consumed Meat"
                        },
                        new
                        {
                            MeatId = 2,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.meijer.com/content/dam/meijer/product/0020/11/5500/00/0020115500000_1_A1C1_0600.png",
                            ImageUrl = "https://www.meijer.com/content/dam/meijer/product/0020/11/5500/00/0020115500000_1_A1C1_0600.png",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Ground beef, minced beef or beef mince is beef that has been finely chopped with a knife or a meat grinder (American English) or mincing machine (British English). It is used in many recipes including hamburgers and spaghetti Bolognese.",
                            Name = "GroundBeef",
                            Price = 12.95m,
                            ShortDescription = "It is used in many recipes including hamburgers and spaghetti Bolognese."
                        },
                        new
                        {
                            MeatId = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.abelandcole.co.uk/media/6615_12936_z.jpg",
                            ImageUrl = "https://www.abelandcole.co.uk/media/6615_12936_z.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Pork belly is a boneless cut of fatty meat from the belly of a pig. Pork belly is particularly popular in Hispanic, Chinese, Korean and Philippine cuisine.",
                            Name = "Pork belly",
                            Price = 12.95m,
                            ShortDescription = "The pork belly is one of the most tasty part of the pork."
                        },
                        new
                        {
                            MeatId = 4,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS79FrJQKd2EDswF19squtc6pHe5kN2S21fUn8YctUON6EPZFqQ&usqp=CAU",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS79FrJQKd2EDswF19squtc6pHe5kN2S21fUn8YctUON6EPZFqQ&usqp=CAU",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "A pork chop, like other meat chops, is a loin cut taken perpendicular to the spine of the pig and usually containing a rib or part of a vertebra. Pork chops are not processed and are leaner than other cuts of pork. Chops are commonly served as an individual portion.",
                            Name = "Pork chop ",
                            Price = 12.95m,
                            ShortDescription = "pork chops are the most commonly consumed meat cut from the pork loin."
                        },
                        new
                        {
                            MeatId = 5,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://livitaly-666b.kxcdn.com/wp-content/uploads/2017/09/bacon2.jpg",
                            ImageUrl = "https://livitaly-666b.kxcdn.com/wp-content/uploads/2017/09/bacon2.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Bacon is a type of salt-cured pork. Bacon is prepared from several different cuts of meat, typically from the pork belly or from back cuts, which have less fat than the belly. It is eaten on its own, as a side dish (particularly in breakfasts), or used as a minor ingredient to flavour dishes (e.g., the club sandwich).",
                            Name = "Bacon",
                            Price = 17.95m,
                            ShortDescription = "Bacon has long been a favorite at breakfast "
                        },
                        new
                        {
                            MeatId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://honest-food.net/wp-content/uploads/2009/10/Hmong-sausage-recipe.jpg",
                            ImageUrl = "https://honest-food.net/wp-content/uploads/2009/10/Hmong-sausage-recipe.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Sausages are a meat product usually made from ground meat, often pork, beef, or poultry, along with salt, spices and other flavourings. Other ingredients such as grains or breadcrumbs may be included as fillers or extenders. Some sausages include other ingredients for flavour.",
                            Name = "Sausages",
                            Price = 15.95m,
                            ShortDescription = "Sausages are a meat product usually made from ground meat"
                        },
                        new
                        {
                            MeatId = 7,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.petramora.com/13281-table/T--Bone-de-ternera.jpg",
                            ImageUrl = "https://www.petramora.com/13281-table/T--Bone-de-ternera.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The T-bone and porterhouse are steaks of beef cut from the short loin (called the sirloin in Commonwealth countries and Ireland). Both steaks include a 'T'-shaped lumbar vertebra with sections of abdominal internal oblique muscle on each side. Porterhouse steaks are cut from the rear end of the short loin and thus include more tenderloin steak, along with (on the other side of the bone) a large strip steak.",
                            Name = "T-bone",
                            Price = 15.95m,
                            ShortDescription = "The T-bone and porterhouse are steaks of beef cut from the short loin"
                        },
                        new
                        {
                            MeatId = 8,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.turnerandgeorge.co.uk/media/catalog/product/cache/image/1704x1364/e9c3970ab036de70892d86c6d221abfe/2/x/2xsirloin_m.jpg",
                            ImageUrl = "https://www.turnerandgeorge.co.uk/media/catalog/product/cache/image/1704x1364/e9c3970ab036de70892d86c6d221abfe/2/x/2xsirloin_m.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The sirloin steak is cut from the sirloin, the subprimal posterior to the short loin where the T-bone, porterhouse, and club steaks are cut. The sirloin is actually divided into several types of steak. The top sirloin is the most prized of these and is specifically marked for sale under that name.",
                            Name = "Sirloin",
                            Price = 15.95m,
                            ShortDescription = "The sirloin steak is cut from the sirloin"
                        },
                        new
                        {
                            MeatId = 9,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.parmashop.com/media/catalog/product/cache/5/thumbnail/500x500/9df78eab33525d08d6e5fb8d27136e95/p/r/prosciutto_di_parma_sliced.jpg",
                            ImageUrl = "https://www.parmashop.com/media/catalog/product/cache/5/thumbnail/500x500/9df78eab33525d08d6e5fb8d27136e95/p/r/prosciutto_di_parma_sliced.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Prosciutto is an Italian dry-cured ham that is usually thinly sliced and served uncooked; this style is called prosciutto crudo in Italian (or simply crudo) and is distinguished from cooked ham, prosciutto cotto.",
                            Name = "Prosciutto",
                            Price = 15.95m,
                            ShortDescription = "Prosciutto is an Italian dry-cured ham"
                        },
                        new
                        {
                            MeatId = 10,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://d2imri64gxn369.cloudfront.net/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/d/b/dbsb0161_20190626500007_1.jpg",
                            ImageUrl = "https://d2imri64gxn369.cloudfront.net/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/d/b/dbsb0161_20190626500007_1.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The rib eye or ribeye is a beef steak from the rib section. The rib section of beef spans from ribs six through twelve. Ribeye steaks are mostly composed of the longissimus dorsi muscle but also contain the complexus and spinalis muscles.",
                            Name = "ribeye",
                            Price = 15.95m,
                            ShortDescription = "The rib eye or ribeye is a beef steak from the rib section "
                        },
                        new
                        {
                            MeatId = 11,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://reddingtonsbutchers.com/wp-content/uploads/2015/11/grand-reserve-english-beef-short-ribs-p44-75_zoom.jpg",
                            ImageUrl = "https://reddingtonsbutchers.com/wp-content/uploads/2015/11/grand-reserve-english-beef-short-ribs-p44-75_zoom.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The term ribs usually refers to the less meaty part of the chops, often cooked as a slab (not cut into separate ribs). They can be roasted, grilled, fried, baked, braised, or smoked. A set of ribs served together (5 or more), is known as a rack (as in a rack of ribs).",
                            Name = "Beef Ribs",
                            Price = 15.95m,
                            ShortDescription = "Beef Ribs usually refers to the less meaty part of the chops."
                        },
                        new
                        {
                            MeatId = 12,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRwFCnv8_JW4Tnv3amMzGja7PhJNvEEHobliH-RO0-XcPriK3yZ&usqp=CAU",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRwFCnv8_JW4Tnv3amMzGja7PhJNvEEHobliH-RO0-XcPriK3yZ&usqp=CAU",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The term ribs usually refers to the less meaty part of the chops, often cooked as a slab (not cut into separate ribs). They can be roasted, grilled, fried, baked, braised, or smoked. A set of ribs served together (5 or more), is known as a rack (as in a rack of ribs).",
                            Name = "Pork Ribs",
                            Price = 15.95m,
                            ShortDescription = "Pork Ribs usually refers to the less meaty part of the chops."
                        },
                        new
                        {
                            MeatId = 13,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0482/3233/products/TopSirloin_16.jpg?v=1537572368",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0482/3233/products/TopSirloin_16.jpg?v=1537572368",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Top sirloin is a cut of beef from the primal loin or subprimal sirloin. Top sirloin steaks differ from sirloin steaks in that the bone and the tenderloin and bottom round muscles have been removed; the remaining major muscles are the gluteus medius and biceps femoris (top sirloin cap steak).",
                            Name = "Top sirloin",
                            Price = 15.95m,
                            ShortDescription = "Top sirloin is a cut of beef from the primal loin or subprimal sirloin."
                        },
                        new
                        {
                            MeatId = 14,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.lobels.com/images/thumbs/0001255_usda-prime-tri-tip_882.jpeg",
                            ImageUrl = "https://www.lobels.com/images/thumbs/0001255_usda-prime-tri-tip_882.jpeg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "The tri-tip is a triangular cut of beef from the bottom sirloin subprimal cut, consisting of the tensor fasciae latae muscle. Untrimmed, the tri-tip weighs around 5 pounds. The cut was known in the United States as early as 1915, called 'the triangle part' of the loin butt. In the U.S., the tri-tip is taken from NAMP cut 185C.",
                            Name = "Tri-tip",
                            Price = 15.95m,
                            ShortDescription = "The tri-tip is a triangular cut of beef."
                        },
                        new
                        {
                            MeatId = 15,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://az836796.vo.msecnd.net/media/image/product/en/large/0021113200000.jpg",
                            ImageUrl = "https://az836796.vo.msecnd.net/media/image/product/en/large/0021113200000.jpg",
                            InStock = 10,
                            IsPreferredMeat = true,
                            LongDescription = "The beef clod or shoulder clod is one of the least expensive cuts of beef and is taken from the shoulder (chuck) region of the animal. Beef clod is a large muscle system, with some fat that covers the muscles. The clod's composition is mainly three muscles: the shoulder tender, the top blade and the clod heart and is one of two chuck subprimal cuts. It is often divided into its three separate muscle cuts for retail sale.",
                            Name = "Beef clod",
                            Price = 12.95m,
                            ShortDescription = "The beef clod or shoulder clod is one of the least expensive cuts of beef."
                        },
                        new
                        {
                            MeatId = 16,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.seriouseats.com/images/2014/12/20141217-tenderloin-roast-recipe-food-lab-10-750x563.jpg",
                            ImageUrl = "https://www.seriouseats.com/images/2014/12/20141217-tenderloin-roast-recipe-food-lab-10-750x563.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "A beef tenderloin, known as an eye fillet in Australasia, filet in France, Filet Mignon in Brazil, and fillet in the United Kingdom and South Africa, is cut from the loin of beef.",
                            Name = "Beef tenderloin",
                            Price = 12.95m,
                            ShortDescription = "beef tenderloin is cut from the loin of beef"
                        },
                        new
                        {
                            MeatId = 17,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.seriouseats.com/recipes/images/2016/06/20160630-pork-tenderloin-sous-vide-21-1500x1125.jpg",
                            ImageUrl = "https://www.seriouseats.com/recipes/images/2016/06/20160630-pork-tenderloin-sous-vide-21-1500x1125.jpg",
                            InStock = 10,
                            IsPreferredMeat = true,
                            LongDescription = "The pork tenderloin, also called pork fillet or Gentleman's Cut, is a long thin cut of pork.As with all quadrupeds, the tenderloin refers to the psoas major muscle along the central spine portion, ventral to the lumbar vertebrae. This is the most tender part of the animal, because these muscles are used for posture, rather than locomotion.",
                            Name = "Pork tenderloin ",
                            Price = 12.95m,
                            ShortDescription = "The pork tenderloin is a long thin cut of pork."
                        },
                        new
                        {
                            MeatId = 18,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://s3-eu-west-1.amazonaws.com/eversfieldorganiccouk/i/pmi/organic_pork_loin_steaks_2.jpg?_t=187129132",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/eversfieldorganiccouk/i/pmi/organic_pork_loin_steaks_2.jpg?_t=187129132",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Pork steaks, sometimes referred to as a Boston butt or pork blade steak , are steaks cut from the shoulder of the pig made which originated from St. Louis, Missouri. Pork Steaks were invented by Winfred E. Steinbruegge of Florissant, MO in 1956 in honor of the birth of his youngest son, Mark W Steinbruegge. Winfred asked Tom Brandt of Tomboy grocery stores, to cut a pork butt into steaks that could be grilled.",
                            Name = "Pork steak",
                            Price = 12.95m,
                            ShortDescription = "Pork steaks, sometimes referred to as a Boston butt or pork blade steak"
                        },
                        new
                        {
                            MeatId = 19,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://shepherdmeats.com/wp-content/uploads/2019/08/Flank-Steak-California-Grass-Fed-min.jpg",
                            ImageUrl = "https://shepherdmeats.com/wp-content/uploads/2019/08/Flank-Steak-California-Grass-Fed-min.jpg",
                            InStock = 10,
                            IsPreferredMeat = false,
                            LongDescription = "Flank steak is a cut of beef taken from the abdominal muscles or lower chest of the steer. French butchers refer to it as bavette, which means 'bib'. Similarly, it is known in Brazil as fraldinha (literally: 'little diaper'). The cut is common in Colombia, where it is known as sobrebarriga ('over the belly').",
                            Name = "Flank steak ",
                            Price = 12.95m,
                            ShortDescription = "Flank steak is a cut of beef taken from the abdominal muscles or lower chest of the steer."
                        });
                });

            modelBuilder.Entity("MeatStore.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MeatStore.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MeatId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("MeatId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MeatStore.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MeatId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("MeatId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("MeatStore.Data.Models.Meat", b =>
                {
                    b.HasOne("MeatStore.Data.Models.Category", "Category")
                        .WithMany("Meats")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MeatStore.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("MeatStore.Data.Models.Meat", "Meat")
                        .WithMany()
                        .HasForeignKey("MeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeatStore.Data.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MeatStore.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("MeatStore.Data.Models.Meat", "Meat")
                        .WithMany()
                        .HasForeignKey("MeatId");
                });
#pragma warning restore 612, 618
        }
    }
}
