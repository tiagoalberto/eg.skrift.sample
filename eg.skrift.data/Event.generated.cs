//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace eg.skrift.data
{
	/// <summary>Event</summary>
	[PublishedContentModel("event")]
	public partial class Event : PublishedContentModel, IEventRating
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "event";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Event(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Event, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Event Summary: Summary of the Event
		///</summary>
		[ImplementPropertyType("eventSummary")]
		public string EventSummary
		{
			get { return this.GetPropertyValue<string>("eventSummary"); }
		}

		///<summary>
		/// Event Title: Title of the Event
		///</summary>
		[ImplementPropertyType("eventTitle")]
		public string EventTitle
		{
			get { return this.GetPropertyValue<string>("eventTitle"); }
		}

		///<summary>
		/// Rating: Event Rating out of 5
		///</summary>
		[ImplementPropertyType("rating")]
		public string Rating
		{
			get { return eg.skrift.data.EventRating.GetRating(this); }
		}
	}
}
