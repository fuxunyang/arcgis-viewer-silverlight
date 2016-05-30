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

namespace ESRI.ArcGIS.Mapping.Controls
{
    [TemplatePart(Name="ThumbTooltipValueDisplay", Type=typeof(TextBlock))]
    public class SliderTooltipControl : UserControl
    {
        TextBlock ThumbTooltipValueDisplay = null;
        public SliderTooltipControl()
        {
            DefaultStyleKey = typeof(SliderTooltipControl);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            ThumbTooltipValueDisplay = GetTemplateChild("ThumbTooltipValueDisplay") as TextBlock;
        }

        public void SetTooltipText(string text)
        {
            if (ThumbTooltipValueDisplay != null)
            {
                ThumbTooltipValueDisplay.Text = text;
            }
        }
    }
}
