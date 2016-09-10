// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ProductCatalog.LoadTester.Generated
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for CatalogServiceAPI.
    /// </summary>
    public static partial class CatalogServiceAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Product> ApiProductsGet(this ICatalogServiceAPI operations)
            {
                return Task.Factory.StartNew(s => ((ICatalogServiceAPI)s).ApiProductsGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Product>> ApiProductsGetAsync(this ICatalogServiceAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiProductsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiProductsByIdGet(this ICatalogServiceAPI operations, string id)
            {
                Task.Factory.StartNew(s => ((ICatalogServiceAPI)s).ApiProductsByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiProductsByIdGetAsync(this ICatalogServiceAPI operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiProductsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}