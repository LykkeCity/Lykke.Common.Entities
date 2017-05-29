using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Common.Entities.Dictionaries
{
    public interface IMarginTradingAsset
    {
        string Id { get; }
        string Name { get; }
        string BaseAssetId { get; }
        string QuoteAssetId { get; }
        int Accuracy { get; }
        int LeverageInit { get; }
        int LeverageMaintenance { get; }
    }

    public class MarginTradingAsset : IMarginTradingAsset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BaseAssetId { get; set; }
        public string QuoteAssetId { get; set; }
        public int Accuracy { get; set; }
        public int LeverageInit { get; set; }
        public int LeverageMaintenance { get; set; }
        public double DeltaBid { get; set; }
        public double DeltaAsk { get; set; }

        public static MarginTradingAsset Create(IMarginTradingAsset src)
        {
            return new MarginTradingAsset
            {
                Id = src.Id,
                Name = src.Name,
                BaseAssetId = src.BaseAssetId,
                QuoteAssetId = src.QuoteAssetId,
                Accuracy = src.Accuracy,
                LeverageMaintenance = src.LeverageMaintenance,
                LeverageInit = src.LeverageInit
            };
        }
    }

    public interface IMarginTradingAssetsRepository
    {
        Task<IEnumerable<IMarginTradingAsset>> GetAllAsync();
        Task<IEnumerable<IMarginTradingAsset>> GetAllAsync(List<string> instruments);
    }
}
