using System.Linq;
using Task1.Classes.Details;
using Task1;

namespace Task1.Classes;

public class Computer
{
    private Motherboard? _motherboard;
    private List<Ram> _rams = new List<Ram>();
    private List<Cpu> _cpus = new List<Cpu>();
    private List<Gpu> _gpus = new List<Gpu>();
    private List<Drive> _drives = new List<Drive>();


    public string? AddDetails(string detailType, string detailName, DetailsStock stock)
    {
        switch(detailType)
        {
            case "motherboard":
                foreach (var mboard in stock.Motherboards)
                {
                    if (!mboard.Name.ToLower().Contains(detailName)) continue;
                    _motherboard = mboard;
                    _rams.Clear();
                    _cpus.Clear();
                    _gpus.Clear();
                    _drives.Clear();
                    break;
                }
                break;
            case "ram":
                if (_motherboard == null) break;
                if (_rams.Count >= _motherboard.RamSlotsCount) break;
                foreach (var ram in stock.Rams)
                {
                    if (!ram.Name.ToLower().Contains(detailName)) continue;
                    if (ram.Type != _motherboard.RamSlotType) continue;
                    _rams.Add(ram);
                    break;
                }                    
                break;
            case "cpu":
                if (_motherboard == null) break;
                foreach (var cpu in stock.Cpus)
                {
                    if (!cpu.Name.ToLower().Contains(detailName)) continue;
                    if (cpu.Socket != _motherboard.Socket) continue;
                    _cpus.Add(cpu);
                    break;
                }
                break;
            case "gpu":
                if (_motherboard == null) break;
                foreach (var gpu in stock.Gpus)
                {
                    if (!gpu.Name.ToLower().Contains(detailName)) continue;
                    _gpus.Add(gpu);
                    break;
                }
                break;
            case "drive":
                if (_motherboard == null) break;
                foreach (var drive in stock.Drives)
                {
                    if (!drive.Name.ToLower().Contains(detailName)) continue;
                    if (_drives.Where(d => d.Interface == drive.Interface)
                               .ToList().Count >= _motherboard.Interfaces[drive.Interface]) break;
                    if (!_motherboard.Interfaces.ContainsKey(drive.Interface)) continue;
                    _drives.Add(drive);
                    break;
                }
                break;
            default:
                return "This category does not exist!";
        }
        return null;
    }

    public string? RemoveDetail(string detailType, string detailName)
    {
        switch (detailType)
        {
            case "motherboard":
                _motherboard = null;
                _rams.Clear();
                _cpus.Clear();
                _gpus.Clear();
                _drives.Clear();
                break;
            case "ram":
                if (_rams.Count == 0) break;
                foreach (var ram in _rams)
                {
                    if (!ram.Name.ToLower().Contains(detailName)) continue;
                    _rams.Remove(ram);
                    break;
                }
                break;
            case "cpu":
                if (_cpus.Count == 0) break;
                foreach (var cpu in _cpus)
                {
                    if (!cpu.Name.ToLower().Contains(detailName)) continue;
                    _cpus.Remove(cpu);
                    break;
                }
                break;
            case "gpu":
                if (_gpus.Count == 0) break;
                foreach (var gpu in _gpus)
                {
                    if (!gpu.Name.ToLower().Contains(detailName)) continue;
                    _gpus.Remove(gpu);
                    break;
                }
                break;
            case "drive":
                if (_drives.Count == 0) break;
                foreach (var drive in _drives)
                {
                    if (!drive.Name.ToLower().Contains(detailName)) continue;
                    _drives.Remove(drive);
                    break;
                }
                break;
            default:
                return "This category does not exist!";
        }
        return null;
    }

    public Dictionary<string, object?> GetDetails()
    {
        Dictionary<string, object?> Details = new Dictionary<string, object?>();
        Details["motherboard"] = _motherboard;
        Details["ram"] = new List<Detail>(_rams);
        Details["cpu"] = new List<Detail>(_cpus);
        Details["gpu"] = new List<Detail>(_gpus);
        Details["drive"] = new List<Detail>(_drives);
        return Details;
    }

    public string Build(decimal budget)
    {
        decimal totalPrice = 0;

        if (_motherboard is null) return "Please add the motherboard to basket!";
        if (_rams.Count == 0) return "Please add the ram to basket!";
        if (_cpus.Count == 0) return "Please add the cpu to basket!";
        if (_gpus.Count == 0) return "Please add the gpu to basket!";
        if (_drives.Count == 0) return "Please add the drive to basket!";

        string totalInfo = "┬─────────────────────<Your PC>─────────────────────•";
        totalInfo += $"\n│ Motherboard: \n│    • {_motherboard.GetInfo()}";
        totalPrice += _motherboard.Price;

        totalInfo += "\n├───────────────────•\n│ Rams: ";
        foreach (Ram detail in _rams) {
            totalInfo += $"\n│    • {detail.GetInfo()}";
            totalPrice += detail.Price;
        }

        totalInfo += "\n├────────────────•\n│ Cpus: ";
        foreach (Cpu detail in _cpus) {
            totalInfo += $"\n│    • {detail.GetInfo()}";
            totalPrice += detail.Price;
        }

        totalInfo += "\n├──────────────•\n│ Gpus: ";
        foreach (Gpu detail in _gpus) {
            totalInfo += $"\n│    • {detail.GetInfo()}";
            totalPrice += detail.Price;
        }

        totalInfo += "\n├────────────────•\n│ Drives: ";
        foreach (Drive detail in _drives) {
            totalInfo += $"\n│    • {detail.GetInfo()}";
            totalPrice += detail.Price;
        }
        totalInfo += $"\n├───────────────────•\n│ Total price: {totalPrice}";
        totalInfo += "\n┴───────────────────────────────────────────────────•";
        if (totalPrice > budget) return "The price is over budget!";

        return totalInfo;
    }
}

