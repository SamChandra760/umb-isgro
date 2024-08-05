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
	// Mixin Content Type with alias "visibilitySettings"
	/// <summary>VisibilitySettings</summary>
	public partial interface IVisibilitySettings : IPublishedElement
	{
		/// <summary>Desktop</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		bool VisibilityDesktop { get; }

		/// <summary>Mobile</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		bool VisibilityMobile { get; }

		/// <summary>Tablet</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		bool VisibilityTablet { get; }
	}

	/// <summary>VisibilitySettings</summary>
	[PublishedModel("visibilitySettings")]
	public partial class VisibilitySettings : PublishedElementModel, IVisibilitySettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const string ModelTypeAlias = "visibilitySettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<VisibilitySettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public VisibilitySettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Desktop: Legt fest ob das Element bei einer Auflösung von größer **≥992px** sichtbar ist.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("visibilityDesktop")]
		public virtual bool VisibilityDesktop => GetVisibilityDesktop(this, _publishedValueFallback);

		/// <summary>Static getter for Desktop</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public static bool GetVisibilityDesktop(IVisibilitySettings that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "visibilityDesktop");

		///<summary>
		/// Mobile: Legt fest ob das Element bei einer Auflösung von kleiner**{768px** sichtbar ist.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("visibilityMobile")]
		public virtual bool VisibilityMobile => GetVisibilityMobile(this, _publishedValueFallback);

		/// <summary>Static getter for Mobile</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public static bool GetVisibilityMobile(IVisibilitySettings that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "visibilityMobile");

		///<summary>
		/// Tablet: Legt fest ob das Element bei einer Auflösung von größer **≥ 768px** und **{ 992px** sichtbar ist.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		[ImplementPropertyType("visibilityTablet")]
		public virtual bool VisibilityTablet => GetVisibilityTablet(this, _publishedValueFallback);

		/// <summary>Static getter for Tablet</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.0+a325ba3")]
		public static bool GetVisibilityTablet(IVisibilitySettings that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "visibilityTablet");
	}
}
