using Microsoft.EntityFrameworkCore.Migrations;

namespace MeatStore.Migrations
{
    public partial class seed_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Cow Meat", "All Cow meats" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Pork Meat", "All Pork meats" });

            migrationBuilder.InsertData(
                table: "Meats",
                columns: new[] { "MeatId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredMeat", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/beef%2520%2528raw%2529.jpg", "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/beef%2520%2528raw%2529.jpg", 10, true, "Beef is the culinary name for meat from cattle, particularly skeletal muscle. Humans have been eating beef since prehistoric times. Beef is a source of high-quality protein and nutrients.", "beef", 7.95m, "The most widely consumed Meat" },
                    { 12, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRwFCnv8_JW4Tnv3amMzGja7PhJNvEEHobliH-RO0-XcPriK3yZ&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRwFCnv8_JW4Tnv3amMzGja7PhJNvEEHobliH-RO0-XcPriK3yZ&usqp=CAU", 10, false, "The term ribs usually refers to the less meaty part of the chops, often cooked as a slab (not cut into separate ribs). They can be roasted, grilled, fried, baked, braised, or smoked. A set of ribs served together (5 or more), is known as a rack (as in a rack of ribs).", "Pork Ribs", 15.95m, "Pork Ribs usually refers to the less meaty part of the chops." },
                    { 9, 2, "https://www.parmashop.com/media/catalog/product/cache/5/thumbnail/500x500/9df78eab33525d08d6e5fb8d27136e95/p/r/prosciutto_di_parma_sliced.jpg", "https://www.parmashop.com/media/catalog/product/cache/5/thumbnail/500x500/9df78eab33525d08d6e5fb8d27136e95/p/r/prosciutto_di_parma_sliced.jpg", 10, false, "Prosciutto is an Italian dry-cured ham that is usually thinly sliced and served uncooked; this style is called prosciutto crudo in Italian (or simply crudo) and is distinguished from cooked ham, prosciutto cotto.", "Prosciutto", 15.95m, "Prosciutto is an Italian dry-cured ham" },
                    { 6, 2, "https://honest-food.net/wp-content/uploads/2009/10/Hmong-sausage-recipe.jpg", "https://honest-food.net/wp-content/uploads/2009/10/Hmong-sausage-recipe.jpg", 10, false, "Sausages are a meat product usually made from ground meat, often pork, beef, or poultry, along with salt, spices and other flavourings. Other ingredients such as grains or breadcrumbs may be included as fillers or extenders. Some sausages include other ingredients for flavour.", "Sausages", 15.95m, "Sausages are a meat product usually made from ground meat" },
                    { 5, 2, "https://livitaly-666b.kxcdn.com/wp-content/uploads/2017/09/bacon2.jpg", "https://livitaly-666b.kxcdn.com/wp-content/uploads/2017/09/bacon2.jpg", 10, false, "Bacon is a type of salt-cured pork. Bacon is prepared from several different cuts of meat, typically from the pork belly or from back cuts, which have less fat than the belly. It is eaten on its own, as a side dish (particularly in breakfasts), or used as a minor ingredient to flavour dishes (e.g., the club sandwich).", "Bacon", 17.95m, "Bacon has long been a favorite at breakfast " },
                    { 4, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS79FrJQKd2EDswF19squtc6pHe5kN2S21fUn8YctUON6EPZFqQ&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS79FrJQKd2EDswF19squtc6pHe5kN2S21fUn8YctUON6EPZFqQ&usqp=CAU", 10, false, "A pork chop, like other meat chops, is a loin cut taken perpendicular to the spine of the pig and usually containing a rib or part of a vertebra. Pork chops are not processed and are leaner than other cuts of pork. Chops are commonly served as an individual portion.", "Pork chop ", 12.95m, "pork chops are the most commonly consumed meat cut from the pork loin." },
                    { 3, 2, "https://www.abelandcole.co.uk/media/6615_12936_z.jpg", "https://www.abelandcole.co.uk/media/6615_12936_z.jpg", 10, false, "Pork belly is a boneless cut of fatty meat from the belly of a pig. Pork belly is particularly popular in Hispanic, Chinese, Korean and Philippine cuisine.", "Pork belly", 12.95m, "The pork belly is one of the most tasty part of the pork." },
                    { 19, 1, "https://shepherdmeats.com/wp-content/uploads/2019/08/Flank-Steak-California-Grass-Fed-min.jpg", "https://shepherdmeats.com/wp-content/uploads/2019/08/Flank-Steak-California-Grass-Fed-min.jpg", 10, false, "Flank steak is a cut of beef taken from the abdominal muscles or lower chest of the steer. French butchers refer to it as bavette, which means 'bib'. Similarly, it is known in Brazil as fraldinha (literally: 'little diaper'). The cut is common in Colombia, where it is known as sobrebarriga ('over the belly').", "Flank steak ", 12.95m, "Flank steak is a cut of beef taken from the abdominal muscles or lower chest of the steer." },
                    { 17, 2, "https://www.seriouseats.com/recipes/images/2016/06/20160630-pork-tenderloin-sous-vide-21-1500x1125.jpg", "https://www.seriouseats.com/recipes/images/2016/06/20160630-pork-tenderloin-sous-vide-21-1500x1125.jpg", 10, true, "The pork tenderloin, also called pork fillet or Gentleman's Cut, is a long thin cut of pork.As with all quadrupeds, the tenderloin refers to the psoas major muscle along the central spine portion, ventral to the lumbar vertebrae. This is the most tender part of the animal, because these muscles are used for posture, rather than locomotion.", "Pork tenderloin ", 12.95m, "The pork tenderloin is a long thin cut of pork." },
                    { 16, 1, "https://www.seriouseats.com/images/2014/12/20141217-tenderloin-roast-recipe-food-lab-10-750x563.jpg", "https://www.seriouseats.com/images/2014/12/20141217-tenderloin-roast-recipe-food-lab-10-750x563.jpg", 10, false, "A beef tenderloin, known as an eye fillet in Australasia, filet in France, Filet Mignon in Brazil, and fillet in the United Kingdom and South Africa, is cut from the loin of beef.", "Beef tenderloin", 12.95m, "beef tenderloin is cut from the loin of beef" },
                    { 14, 1, "https://www.lobels.com/images/thumbs/0001255_usda-prime-tri-tip_882.jpeg", "https://www.lobels.com/images/thumbs/0001255_usda-prime-tri-tip_882.jpeg", 10, false, "The tri-tip is a triangular cut of beef from the bottom sirloin subprimal cut, consisting of the tensor fasciae latae muscle. Untrimmed, the tri-tip weighs around 5 pounds. The cut was known in the United States as early as 1915, called 'the triangle part' of the loin butt. In the U.S., the tri-tip is taken from NAMP cut 185C.", "Tri-tip", 15.95m, "The tri-tip is a triangular cut of beef." },
                    { 13, 1, "https://cdn.shopify.com/s/files/1/0482/3233/products/TopSirloin_16.jpg?v=1537572368", "https://cdn.shopify.com/s/files/1/0482/3233/products/TopSirloin_16.jpg?v=1537572368", 10, false, "Top sirloin is a cut of beef from the primal loin or subprimal sirloin. Top sirloin steaks differ from sirloin steaks in that the bone and the tenderloin and bottom round muscles have been removed; the remaining major muscles are the gluteus medius and biceps femoris (top sirloin cap steak).", "Top sirloin", 15.95m, "Top sirloin is a cut of beef from the primal loin or subprimal sirloin." },
                    { 11, 1, "https://reddingtonsbutchers.com/wp-content/uploads/2015/11/grand-reserve-english-beef-short-ribs-p44-75_zoom.jpg", "https://reddingtonsbutchers.com/wp-content/uploads/2015/11/grand-reserve-english-beef-short-ribs-p44-75_zoom.jpg", 10, false, "The term ribs usually refers to the less meaty part of the chops, often cooked as a slab (not cut into separate ribs). They can be roasted, grilled, fried, baked, braised, or smoked. A set of ribs served together (5 or more), is known as a rack (as in a rack of ribs).", "Beef Ribs", 15.95m, "Beef Ribs usually refers to the less meaty part of the chops." },
                    { 10, 1, "https://d2imri64gxn369.cloudfront.net/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/d/b/dbsb0161_20190626500007_1.jpg", "https://d2imri64gxn369.cloudfront.net/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/d/b/dbsb0161_20190626500007_1.jpg", 10, false, "The rib eye or ribeye is a beef steak from the rib section. The rib section of beef spans from ribs six through twelve. Ribeye steaks are mostly composed of the longissimus dorsi muscle but also contain the complexus and spinalis muscles.", "ribeye", 15.95m, "The rib eye or ribeye is a beef steak from the rib section " },
                    { 8, 1, "https://www.turnerandgeorge.co.uk/media/catalog/product/cache/image/1704x1364/e9c3970ab036de70892d86c6d221abfe/2/x/2xsirloin_m.jpg", "https://www.turnerandgeorge.co.uk/media/catalog/product/cache/image/1704x1364/e9c3970ab036de70892d86c6d221abfe/2/x/2xsirloin_m.jpg", 10, false, "The sirloin steak is cut from the sirloin, the subprimal posterior to the short loin where the T-bone, porterhouse, and club steaks are cut. The sirloin is actually divided into several types of steak. The top sirloin is the most prized of these and is specifically marked for sale under that name.", "Sirloin", 15.95m, "The sirloin steak is cut from the sirloin" },
                    { 7, 1, "https://www.petramora.com/13281-table/T--Bone-de-ternera.jpg", "https://www.petramora.com/13281-table/T--Bone-de-ternera.jpg", 10, false, "The T-bone and porterhouse are steaks of beef cut from the short loin (called the sirloin in Commonwealth countries and Ireland). Both steaks include a 'T'-shaped lumbar vertebra with sections of abdominal internal oblique muscle on each side. Porterhouse steaks are cut from the rear end of the short loin and thus include more tenderloin steak, along with (on the other side of the bone) a large strip steak.", "T-bone", 15.95m, "The T-bone and porterhouse are steaks of beef cut from the short loin" },
                    { 2, 1, "https://www.meijer.com/content/dam/meijer/product/0020/11/5500/00/0020115500000_1_A1C1_0600.png", "https://www.meijer.com/content/dam/meijer/product/0020/11/5500/00/0020115500000_1_A1C1_0600.png", 10, false, "Ground beef, minced beef or beef mince is beef that has been finely chopped with a knife or a meat grinder (American English) or mincing machine (British English). It is used in many recipes including hamburgers and spaghetti Bolognese.", "GroundBeef", 12.95m, "It is used in many recipes including hamburgers and spaghetti Bolognese." },
                    { 15, 1, "https://az836796.vo.msecnd.net/media/image/product/en/large/0021113200000.jpg", "https://az836796.vo.msecnd.net/media/image/product/en/large/0021113200000.jpg", 10, true, "The beef clod or shoulder clod is one of the least expensive cuts of beef and is taken from the shoulder (chuck) region of the animal. Beef clod is a large muscle system, with some fat that covers the muscles. The clod's composition is mainly three muscles: the shoulder tender, the top blade and the clod heart and is one of two chuck subprimal cuts. It is often divided into its three separate muscle cuts for retail sale.", "Beef clod", 12.95m, "The beef clod or shoulder clod is one of the least expensive cuts of beef." },
                    { 18, 2, "https://s3-eu-west-1.amazonaws.com/eversfieldorganiccouk/i/pmi/organic_pork_loin_steaks_2.jpg?_t=187129132", "https://s3-eu-west-1.amazonaws.com/eversfieldorganiccouk/i/pmi/organic_pork_loin_steaks_2.jpg?_t=187129132", 10, false, "Pork steaks, sometimes referred to as a Boston butt or pork blade steak , are steaks cut from the shoulder of the pig made which originated from St. Louis, Missouri. Pork Steaks were invented by Winfred E. Steinbruegge of Florissant, MO in 1956 in honor of the birth of his youngest son, Mark W Steinbruegge. Winfred asked Tom Brandt of Tomboy grocery stores, to cut a pork butt into steaks that could be grilled.", "Pork steak", 12.95m, "Pork steaks, sometimes referred to as a Boston butt or pork blade steak" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meats",
                keyColumn: "MeatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
