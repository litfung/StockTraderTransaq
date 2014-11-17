//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
using System;
using StockTraderTransaq.Infrastructure.Interfaces;
using StockTraderTransaq.Infrastructure.Models;

namespace StockTraderTransaq.Modules.Position.Tests.Mocks
{
    public class MockMarketHistoryService : IMarketHistoryService
    {
        #region IMarketHistoryService Members

        public MarketHistoryCollection GetPriceHistory(string tickerSymbol)
        {
            //return new MarketHistoryCollection { 
            //    new MarketHistoryItem { DateTimeMarker = new DateTime(1), Value = 1.00m }
            //    , new MarketHistoryItem { DateTimeMarker = new DateTime(2), Value =  2.00m}
            //};

            throw new NotImplementedException();
        }

        #endregion
    }
}
