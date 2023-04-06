﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the Model3DReferenceRelationshipPart
    /// </summary>
    public partial class Model3DReferenceRelationshipPart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "model/gltf-binary";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/model3d";

        /// <summary>
        /// Creates an instance of the Model3DReferenceRelationshipPart OpenXmlType
        /// </summary>
        internal Model3DReferenceRelationshipPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Extension => ".glb";
            string ITargetFeature.Name => "model3d";
            string ITargetFeature.Path => "../media";
        }
    
    }
}
