﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.view
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler EditEvent;

        void SetPayModeListBildingSource(BindingSource PayModeList);

        void Show();
    }
}
