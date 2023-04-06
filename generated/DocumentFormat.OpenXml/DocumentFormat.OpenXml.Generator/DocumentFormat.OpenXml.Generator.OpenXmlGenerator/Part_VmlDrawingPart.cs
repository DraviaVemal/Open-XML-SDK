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
    /// Defines the VmlDrawingPart
    /// </summary>
    public partial class VmlDrawingPart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.vmlDrawing";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing";

        /// <summary>
        /// Creates an instance of the VmlDrawingPart OpenXmlType
        /// </summary>
        internal VmlDrawingPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ImageParts of the VmlDrawingPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <summary>
        /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
        /// </summary>
        public IEnumerable<LegacyDiagramTextPart> LegacyDiagramTextParts => GetPartsOfType<LegacyDiagramTextPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Adds a ImagePart to the VmlDrawingPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the VmlDrawingPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the VmlDrawingPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the VmlDrawingPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            return AddImagePart(contentType);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Extension => ".vml";
            string ITargetFeature.Name => "vmldrawing";
            string ITargetFeature.Path => "../drawings";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText", "application/vnd.ms-office.legacyDiagramText", false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
