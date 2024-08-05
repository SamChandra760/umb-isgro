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
	/// <summary>Tools Section</summary>
	[PublishedModel("toolsSection")]
	public partial class ToolsSection : MasterTools, IFeedback, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const string ModelTypeAlias = "toolsSection";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ToolsSection, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ToolsSection(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Banner: nach Tutorials
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("banner1")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Banner1 => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "banner1");

		///<summary>
		/// Banner: am Ende der Seite
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("banner2")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Banner2 => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "banner2");

		///<summary>
		/// Basis Platzhalter: Header-Bild, welches im Header-Bereich eines Tools bei einer Basisauflistung angezeigt wird.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("basisPlaceholder")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops BasisPlaceholder => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "basisPlaceholder");

		///<summary>
		/// Beansprucht: Platzhalter Werte: [toolProvider] = Anbieter Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("claimed")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Claimed => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "claimed");

		///<summary>
		/// E-Mail: Benachrichtigungen über Sponsored Posts sowie die CSV mit den Änderungen auf den Anbieter- und Tools-Knoten werden an diese E-Mail-Adresse gesendet,
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eMailCsv")]
		public virtual string EMailCsv => this.Value<string>(_publishedValueFallback, "eMailCsv");

		///<summary>
		/// Counter Kategorie Zahl
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("footerCounterCategoryAmount")]
		public virtual int FooterCounterCategoryAmount => this.Value<int>(_publishedValueFallback, "footerCounterCategoryAmount");

		///<summary>
		/// Counter Kategorien Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerCounterCategoryText")]
		public virtual string FooterCounterCategoryText => this.Value<string>(_publishedValueFallback, "footerCounterCategoryText");

		///<summary>
		/// Counter Tools Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerCounterToolsText")]
		public virtual string FooterCounterToolsText => this.Value<string>(_publishedValueFallback, "footerCounterToolsText");

		///<summary>
		/// Menüpunkte
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerMenu")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent> FooterMenu => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>>(_publishedValueFallback, "footerMenu");

		///<summary>
		/// Tax & Bytes Slogan
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerTextTaxAndBytes")]
		public virtual string FooterTextTaxAndBytes => this.Value<string>(_publishedValueFallback, "footerTextTaxAndBytes");

		///<summary>
		/// Tools-Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerTextTools")]
		public virtual string FooterTextTools => this.Value<string>(_publishedValueFallback, "footerTextTools");

		///<summary>
		/// Formular Link: Link zum Registrierungs- / Upgrade Formular
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("formularLink")]
		public virtual string FormularLink => this.Value<string>(_publishedValueFallback, "formularLink");

		///<summary>
		/// Wartungsseite
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("maintenancePage")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent MaintenancePage => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "maintenancePage");

		///<summary>
		/// Wartungsseite aktivieren
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("maintenancePageIsActive")]
		public virtual bool MaintenancePageIsActive => this.Value<bool>(_publishedValueFallback, "maintenancePageIsActive");

		///<summary>
		/// Nicht Beansprucht: Platzhalter Werte: [toolProvider] = Anbieter Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("notClaimed")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString NotClaimed => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "notClaimed");

		///<summary>
		/// Angeteaserte Beiträge Tools Startseite
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("taxAndBytesHighlight")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel TaxAndBytesHighlight => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "taxAndBytesHighlight");

		///<summary>
		/// Feedback Bild
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("feedbackAvatar")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FeedbackAvatar => global::Umbraco.Cms.Web.Common.PublishedModels.Feedback.GetFeedbackAvatar(this, _publishedValueFallback);

		///<summary>
		/// Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("feedbackHeadline")]
		public virtual string FeedbackHeadline => global::Umbraco.Cms.Web.Common.PublishedModels.Feedback.GetFeedbackHeadline(this, _publishedValueFallback);

		///<summary>
		/// Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("feedbackLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link FeedbackLink => global::Umbraco.Cms.Web.Common.PublishedModels.Feedback.GetFeedbackLink(this, _publishedValueFallback);

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("feedbackText")]
		public virtual string FeedbackText => global::Umbraco.Cms.Web.Common.PublishedModels.Feedback.GetFeedbackText(this, _publishedValueFallback);

		///<summary>
		/// An/Aus
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("feedbackToggle")]
		public virtual bool FeedbackToggle => global::Umbraco.Cms.Web.Common.PublishedModels.Feedback.GetFeedbackToggle(this, _publishedValueFallback);

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
