﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoGramBot.Configuration
{
    public class BinanceConfig : IConfig
    {
        public bool BuyNotifications { get; set; }
        public double CommissionPercentage { get; set; }
        public string DailyNotifications { get; set; }
        public bool Enabled { get; set; }
        public string Key { get; set; }
        public bool OpenOrderNotification { get; set; }
        public string Secret { get; set; }
        public bool SellNotifications { get; set; }
        public bool SendHourlyUpdates { get; set; }
    }
}