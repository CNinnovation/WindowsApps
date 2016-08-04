﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace GeneratedProxyClient.Models
{
    public partial class Book
    {
        private int? _bookId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? BookId
        {
            get { return this._bookId; }
            set { this._bookId = value; }
        }
        
        private string _publisher;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }
        
        private string _title;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Book class.
        /// </summary>
        public Book()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken bookIdValue = inputObject["bookId"];
                if (bookIdValue != null && bookIdValue.Type != JTokenType.Null)
                {
                    this.BookId = ((int)bookIdValue);
                }
                JToken publisherValue = inputObject["publisher"];
                if (publisherValue != null && publisherValue.Type != JTokenType.Null)
                {
                    this.Publisher = ((string)publisherValue);
                }
                JToken titleValue = inputObject["title"];
                if (titleValue != null && titleValue.Type != JTokenType.Null)
                {
                    this.Title = ((string)titleValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Book
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.BookId != null)
            {
                outputObject["bookId"] = this.BookId.Value;
            }
            if (this.Publisher != null)
            {
                outputObject["publisher"] = this.Publisher;
            }
            if (this.Title != null)
            {
                outputObject["title"] = this.Title;
            }
            return outputObject;
        }
    }
}
