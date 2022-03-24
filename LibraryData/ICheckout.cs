using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        void Add(CheckoutModel newCheckout);

        IEnumerable<CheckoutModel> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        CheckoutModel GetById(int checkoutId);
        CheckoutModel GetLatestCheckout(int assetId);
        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        bool IsCheckedOut(int id);
       
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        void PlaceHold(int assetId, int libraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
