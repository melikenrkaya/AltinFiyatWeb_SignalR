using AltınFiyatWeb__SignalR_.Data.Entity;
using AltınFiyatWeb__SignalR_.Data.Model;

 namespace AltınFiyatWeb__SignalR_.Common
{
    public static class PriceListExten
    {
        public static PriceListDto ToPriceListDto(this PriceList PriceListModel)
        {
            return new PriceListDto
            {
                Id = PriceListModel.Id,
                PropertySuffixId = PriceListModel.PropertySuffixId,
                BuyPrice = PriceListModel.BuyPrice,
                SellPrice = PriceListModel.SellPrice,
                UpdatedTime = PriceListModel.UpdatedTime,

            };
        }
    }
}
