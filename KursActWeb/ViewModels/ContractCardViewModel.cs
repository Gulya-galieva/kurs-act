using DbManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursActWeb.ViewModels
{
    public class ContractCardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Статистика по ТУ
        public int CountSubstations { get; set; }
        public int CountRegPoints { get; set; }
        public int CountLinkOk { get; set; }
        public int CountAscueChecked { get; set; }
        public int CountAscueOk { get; set; }
        public int CountOther { get; set; }
        //Проценты
        public int PercentLinkOk { get; set; }
        public int PercentAscueChecked { get; set; }
        public int PercentAscueOk { get; set; }
        public int PercentOther { get; set; }

        public string ColorClass
        {
            get
            {
                int colorIdx = Id % 10;
                if (colorIdx == 0) return "bg-primary";
                if (colorIdx == 1) return "bg-info";
                if (colorIdx == 2) return "bg-success";
                if (colorIdx == 3) return "bg-secondary";
                if (colorIdx == 4) return "bg-danger";
                if (colorIdx == 5) return "bg-warning";
                if (colorIdx == 6) return "bg-success";
                if (colorIdx == 7) return "bg-dark";
                if (colorIdx == 8) return "bg-info";
                if (colorIdx == 9) return "bg-primary";
                return "bg-info";
            }
        }

        public ContractCardViewModel(int contractId)
        {
            using (StoreContext db = new StoreContext())
            {
                var contract = db.Contracts.Find(contractId);
                if (contract != null)
                {
                    Id = contract.Id;
                    Name = contract.Name;
                    Description = contract.Description;
                    //Всего объектов и точек учета
                    CountSubstations = db.Substations.Count(s => s.NetRegion.ContractId == Id);
                    CountRegPoints = db.RegPoints.Count(rp => rp.Substation.NetRegion.ContractId == Id && rp.Status == RegPointStatus.Default);
                    //Статистика по ТУ
                    CountLinkOk = db.RegPoints.Count(rp => rp.Substation.NetRegion.ContractId == Id && rp.RegPointFlags.IsLinkOk && !rp.RegPointFlags.IsAscueChecked && !rp.RegPointFlags.IsAscueOk);
                    CountAscueChecked = db.RegPoints.Count(rp => rp.Substation.NetRegion.ContractId == Id && rp.RegPointFlags.IsAscueChecked && !rp.RegPointFlags.IsAscueOk);
                    CountAscueOk = db.RegPoints.Count(rp => rp.Substation.NetRegion.ContractId == Id && rp.RegPointFlags.IsAscueOk);
                    CountOther = CountRegPoints - (CountLinkOk + CountAscueChecked + CountAscueOk);
                    //Статистика Проценты
                    if (CountRegPoints > 0)
                    {
                        PercentLinkOk = CountLinkOk * 100 / CountRegPoints;
                        PercentAscueChecked = CountAscueChecked * 100 / CountRegPoints;
                        PercentAscueOk = CountAscueOk * 100 / CountRegPoints;
                        PercentOther = 100 - (PercentLinkOk + PercentAscueChecked + PercentAscueOk);
                    }
                }
                else
                    throw new Exception("Нулевая ссылка на объект 'Контракт'");
            }
                
            
        }
    }
}
