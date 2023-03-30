using Task1.Classes;
using Task1.Classes.Details;

namespace Task1;

public class DetailsStock
{
    
    public List<Motherboard> Motherboards = new List<Motherboard>()
    {
        new Motherboard(2800, "Asus", "USA", "Prime H510M-K", "s1200", 2, "DDR4", new Dictionary<string, int>() { {"SATA3", 4}, {"M.2", 1} }),
        new Motherboard(27000, "Asus", "USA", "ROG Maximus Z790 Hero", "s1700", 4, "DDR5", new Dictionary<string, int>() { {"SATA3", 6}, {"M.2", 5} }),
        new Motherboard(4570, "Gigabyte", "USA", "B560M DS3H V2", "s1200", 4, "DDR4", new Dictionary<string, int>() { {"SATA3", 6}, {"M.2", 2} }),
        new Motherboard(2880, "Asus", "USA", "Prime B450M-K II", "sAM4", 2, "DDR4", new Dictionary<string, int>() { {"SATA3", 4}, {"M.2", 1} }),
        new Motherboard(600, "Asus", "USA", "P5K SE/EPU", "s775", 4, "DDR3", new Dictionary<string, int>() { {"SATA3", 4}, {"IDE", 1} })
    };
    public List<Ram> Rams = new List<Ram>()
    {
        new Ram(10200, "G.Skill", "USA", "Trident Z5 RGB Black 32GB", "DDR5", "32768MB"),
        new Ram(880, "Goodram", "USA", "Goodram 8GB", "DDR3", "8192MB"),
        new Ram(3579, "Kingston", "USA", "Renegade RGB Black 16GB", "DDR5", "16384MB"),
        new Ram(1129, "Kingston", "USA", "Beast Black 8GB", "DDR4", "8192MB")
    };
    public List<Cpu> Cpus = new List<Cpu>()
    {
        new Cpu(5100, "Intel", "USA", "i5-11400F", "s1200", "6/12", "2.6GHz - 4.4GHz"),
        new Cpu(3900, "AMD", "USA", "Ryzen 5 5500", "sAM4", "6/12", "3.6GHz - 4.2GHz"),
        new Cpu(18600, "Intel", "USA", "i7-13700K", "s1700", "16/24", "3.4GHz - 5.4GHz"),
    };
    public List<Gpu> Gpus = new List<Gpu>()
    {
        new Gpu(16100, "ASUS", "USA", "GeForce RTX 3060 Dual OC V2 LHR", "12GB", "1867MHz"),
        new Gpu(2090, "Gigabyte", "USA", "GeForce GT 710", "2GB", "954MHz"),
        new Gpu(11000, "Gigabyte", "USA", "GeForce GTX 1660 Super D6 6G", "6GB", "1785MHz"),
        new Gpu(45000, "ASUS", "USA", "GeForce RTX 4070 Ti ROG Strix OC Edition", "12GB", "2640MHz"),
    };
    public List<Drive> Drives = new List<Drive>()
    {
        new Drive(1230, "Kingston", "USA", "SSDNow A400", "SSD", "480GB", "500MB/s - 450MB/s", "SATA3", "114,1 years"),
        new Drive(1740, "Samsung", "USA", "SSD 980", "SSD", "500GB", "3100MB/s - 2600MB/s", "M.2", "171,2 years"),
        new Drive(2155, "Seagate", "USA", "Barracuda", "HDD", "2TB", "140MB/s - 140MB/s", "SATA3", null),
        new Drive(2100, "WD", "USA", "Western Digital Purple WD10PURZ", "HDD", "1TB", "320MB/s - 260MB/s", "SATA3", null),
        new Drive(3880, "Samsung", "USA", "870 Evo-Series", "SSD", "1TB", "560MB/s - 530MB/s", "SATA3", "171,2 years"),
        new Drive(9630, "Kingston", "USA", "FURY Renegade SSD", "SSD", "2TB", "7300MB/s - 7000MB/s", "M.2", "205,4 years"),
    };
}
