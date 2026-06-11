using Terrasoft.Common;

namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Common;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    [EntityEventListener(SchemaName = "UsrRealty")]
    public class RealtyEntityEventListener : BaseEntityEventListener
    {
        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            base.OnSaving(sender, e);
            Entity Realty = (Entity)sender;
            decimal price = Realty.GetTypedColumnValue<decimal>("UsrPrice");
            if (price > 1000000000)
            {
                e.IsCanceled = true;
                string messageTemp = new LocalizableString(Realty.UserConnection.ResourceStorage,
                    "UsrRealtyEvents", "PriceExceedsLimitMessage.value").ToString();
                string message = string.Format(messageTemp, "1.0B$");
                throw new Exception(message);
            }
        }
    }
}

