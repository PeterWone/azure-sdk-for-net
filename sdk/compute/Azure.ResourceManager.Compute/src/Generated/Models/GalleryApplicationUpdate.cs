// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Definition that you want to update. </summary>
    public partial class GalleryApplicationUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryApplicationUpdate. </summary>
        public GalleryApplicationUpdate()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationUpdate. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> The description of this gallery Application Definition resource. This property is updatable. </param>
        /// <param name="eula"> The Eula agreement for the gallery Application Definition. </param>
        /// <param name="privacyStatementUri"> The privacy statement uri. </param>
        /// <param name="releaseNoteUri"> The release note uri. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="supportedOSType"> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        internal GalleryApplicationUpdate(string id, string name, string type, IDictionary<string, string> tags, string description, string eula, string privacyStatementUri, string releaseNoteUri, DateTimeOffset? endOfLifeDate, OperatingSystemTypes? supportedOSType) : base(id, name, type, tags)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            EndOfLifeDate = endOfLifeDate;
            SupportedOSType = supportedOSType;
        }

        /// <summary> The description of this gallery Application Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Application Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public string PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public string ReleaseNoteUri { get; set; }
        /// <summary> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; set; }
        /// <summary> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? SupportedOSType { get; set; }
    }
}
