// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Statistics for a given index. Statistics are collected periodically and are not guaranteed to always be up-to-date. </summary>
    public partial class SearchIndexStatistics
    {
        /// <summary> Initializes a new instance of SearchIndexStatistics. </summary>
        /// <param name="documentCount"> The number of documents in the index. </param>
        /// <param name="storageSize"> The amount of storage in bytes consumed by the index. </param>
        internal SearchIndexStatistics(long documentCount, long storageSize)
        {
            DocumentCount = documentCount;
            StorageSize = storageSize;
        }

        /// <summary> The number of documents in the index. </summary>
        public long DocumentCount { get; }
        /// <summary> The amount of storage in bytes consumed by the index. </summary>
        public long StorageSize { get; }
    }
}
