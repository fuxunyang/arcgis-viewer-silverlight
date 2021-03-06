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
using ESRI.ArcGIS.Mapping.Controls;
using ESRI.ArcGIS.Client.Extensibility;

namespace ESRI.ArcGIS.Mapping.Builder
{
    public class ManageApplicationPropertiesCommand : CommandBase
    {
        ApplicationPropertiesDialog appPropertiesDialog;
        public override void Execute(object parameter)
        {
            appPropertiesDialog = appPropertiesDialog ?? new ApplicationPropertiesDialog();
            BuilderApplication.Instance.ShowWindow(ESRI.ArcGIS.Mapping.Builder.Resources.Strings.ChangeTitleAndLinks, appPropertiesDialog);
        }
    }
}
