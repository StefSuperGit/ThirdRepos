﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private decimal amountDue;
        private decimal mPrice;
        // feat 1.2 now requires a Child Discount Field
        private bool childDiscount;
        
        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        // feat 1.2
        const decimal mdecChildDiscount = 10m;
        // FEAT 1.1 Creating Constant
        const decimal mdecBackStall = 15.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        // Feat 1.2 Requiures Getters/ Setters for child discount
        private bool ChildDiscount
        {
            get { return childDiscount; }
            set { childDiscount = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice     Feat 1.2 Now has child Discount
    public TicketPrice(int section, int quantity, bool discount, bool childDiscount)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
        // Feat 1.2
        ChildDiscount = childDiscount;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
             // Feat 1.1 Back Stall
             case 4:
                 mPrice = mdecBackStall;
                 break;
         }
         if (discount)
         { mPrice -= mdecDiscount; }

        //  Feat 1.2 Requires if for child Discount
        if (childDiscount)
        {
            mPrice -= mdecChildDiscount;
        }

         AmountDue = mPrice * quantity;

     }
    }
}
