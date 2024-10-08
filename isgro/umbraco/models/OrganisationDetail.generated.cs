//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.3.0+a325ba3
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Organisation Ansicht</summary>
	[PublishedModel("organisationDetail")]
	public partial class OrganisationDetail : Master, ICtaLinkList, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const string ModelTypeAlias = "organisationDetail";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<OrganisationDetail, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public OrganisationDetail(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Alternatives Bild: **Crop Name**: Detail Stage BackgroundImage  Dieses Bild wird als Header-Bild verwendet, wenn es ausgewählt ist.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("alternativeCover")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AlternativeCover => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "alternativeCover");

		///<summary>
		/// Flächen-Vorschau
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("areaThumbnail")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AreaThumbnail => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "areaThumbnail");

		///<summary>
		/// Blur Stärke: Lege die Intensität des Blur Effekts fest. Standard ist 100px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("blurValue")]
		public virtual decimal BlurValue => this.Value<decimal>(_publishedValueFallback, "blurValue");

		///<summary>
		/// Blur Effekt: Wenn Blur aktiviert ist wird kein Crop verwendet.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("disableBlur")]
		public virtual bool DisableBlur => this.Value<bool>(_publishedValueFallback, "disableBlur");

		///<summary>
		/// Schlagworte
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationBullets")]
		public virtual global::System.Collections.Generic.IEnumerable<string> OrganisationBullets => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "organisationBullets");

		///<summary>
		/// Inhalt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationContent")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel OrganisationContent => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel>(_publishedValueFallback, "organisationContent");

		///<summary>
		/// Überschrift
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationHeadline")]
		public virtual string OrganisationHeadline => this.Value<string>(_publishedValueFallback, "organisationHeadline");

		///<summary>
		/// Bild
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OrganisationImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "organisationImage");

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OrganisationLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "organisationLogo");

		///<summary>
		/// Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationName")]
		public virtual string OrganisationName => this.Value<string>(_publishedValueFallback, "organisationName");

		///<summary>
		/// Quelle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("organisationSource")]
		public virtual global::Umbraco.Cms.Core.Models.Link OrganisationSource => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "organisationSource");

		///<summary>
		/// In Übersicht ausblenden?
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("overviewHide")]
		public virtual bool OverviewHide => this.Value<bool>(_publishedValueFallback, "overviewHide");

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("previewThumbnail")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PreviewThumbnail => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "previewThumbnail");

		///<summary>
		/// Gründungsjahr
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("sidebarFoundingDate")]
		public virtual int SidebarFoundingDate => this.Value<int>(_publishedValueFallback, "sidebarFoundingDate");

		///<summary>
		/// Organisationsform
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarOrganisationType")]
		public virtual string SidebarOrganisationType => this.Value<string>(_publishedValueFallback, "sidebarOrganisationType");

		///<summary>
		/// Standort
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarPlaces")]
		public virtual string SidebarPlaces => this.Value<string>(_publishedValueFallback, "sidebarPlaces");

		///<summary>
		/// Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("links")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> Links => global::Umbraco.Cms.Web.Common.PublishedModels.CtaLinkList.GetLinks(this, _publishedValueFallback);

		///<summary>
		/// Page Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageMetaDescription")]
		public virtual string PageMetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetPageMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Page Meta Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageMetaKeywords")]
		public virtual string PageMetaKeywords => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetPageMetaKeywords(this, _publishedValueFallback);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetPageTitle(this, _publishedValueFallback);
	}
}
