/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System;
using System.Collections.Generic;
using System.Web;
using ESRI.ArcGIS.Mapping.Builder.Server;

namespace ESRI.ArcGIS.Mapping.Builder.Web
{
    public class DeleteExtensionRequestHandler : DeleteExtensionRequestHandlerBase
    {
        protected override void DeleteExtension(string extensionFileName)
        {
            ExtensionsManager.DeleteExtensionLibraryFromDisk(extensionFileName);
            ExtensionsManager.RemoveExtensionLibraryFromCatalog(extensionFileName);
        }
    }
}
