/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using ESRI.ArcGIS.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ESRI.ArcGIS.Mapping.Controls
{
    public class GetSubLayersItemSourceConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ArcGISDynamicMapServiceLayer dynLayer = value as ArcGISDynamicMapServiceLayer;
            if (dynLayer == null)
                return null;
            List<TreeViewItem> items = new List<TreeViewItem> { };
            items.Add(new TreeViewItem(){});
            return items;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
