﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GeneratedProxyClient;
using GeneratedProxyClient.Models;
using Microsoft.Rest;

namespace GeneratedProxyClient
{
    public static partial class APIV1Extensions
    {
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Book ApiBooksByIdGet(this IAPIV1 operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiBooksByIdGetAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Book> ApiBooksByIdGetAsync(this IAPIV1 operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<GeneratedProxyClient.Models.Book> result = await operations.ApiBooksByIdGetWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        public static object ApiBooksByIdPut(this IAPIV1 operations, int id, Book value = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiBooksByIdPutAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> ApiBooksByIdPutAsync(this IAPIV1 operations, int id, Book value = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.ApiBooksByIdPutWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        public static IList<Book> ApiBooksGet(this IAPIV1 operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiBooksGetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Book>> ApiBooksGetAsync(this IAPIV1 operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<GeneratedProxyClient.Models.Book>> result = await operations.ApiBooksGetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        public static object ApiBooksPost(this IAPIV1 operations, Book value = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiBooksPostAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> ApiBooksPostAsync(this IAPIV1 operations, Book value = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.ApiBooksPostWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object ApiValuesByIdDelete(this IAPIV1 operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiValuesByIdDeleteAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> ApiValuesByIdDeleteAsync(this IAPIV1 operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.ApiValuesByIdDeleteWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static string ApiValuesByIdGet(this IAPIV1 operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiValuesByIdGetAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> ApiValuesByIdGetAsync(this IAPIV1 operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.ApiValuesByIdGetWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        public static object ApiValuesByIdPut(this IAPIV1 operations, int id, string value = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiValuesByIdPutAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> ApiValuesByIdPutAsync(this IAPIV1 operations, int id, string value = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.ApiValuesByIdPutWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        public static IList<string> ApiValuesGet(this IAPIV1 operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiValuesGetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<string>> ApiValuesGetAsync(this IAPIV1 operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<string>> result = await operations.ApiValuesGetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        public static object ApiValuesPost(this IAPIV1 operations, string value = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAPIV1)s).ApiValuesPostAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the GeneratedProxyClient.IAPIV1.
        /// </param>
        /// <param name='value'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> ApiValuesPostAsync(this IAPIV1 operations, string value = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.ApiValuesPostWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
