 foreach (var pm in brands)
            {
                var manufacturer = pm.Manufacturer;

                if (!cachedModels.TryGetValue(manufacturer.Id, out BrandOverviewModel item))
                {
                    item = new BrandOverviewModel
                    {
                        Id = manufacturer.Id,
                        Name = manufacturer.GetLocalized(x => x.Name),
                        Description = manufacturer.GetLocalized(x => x.Description, true),
                        SeName = manufacturer.GetActiveSlug()
                    };
 if (!ModelState.IsValid)
            {
                return false;
            }

            var paymentInfo = await paymentMethod.GetPaymentInfoAsync(form);
            HttpContext.Session.TrySetObject("OrderPaymentInfo", paymentInfo);

            var state = _checkoutStateAccessor.CheckoutState;
            state.PaymentSummary = await paymentMethod.GetPaymentSummaryAsync();

            return true;
        }
//nice
 if (!cart.HasItems)
            {
                return RedirectToRoute("ShoppingCart");
            }
