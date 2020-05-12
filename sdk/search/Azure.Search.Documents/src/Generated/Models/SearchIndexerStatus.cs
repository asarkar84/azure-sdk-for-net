// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> Represents the current status and execution history of an indexer. </summary>
    public partial class SearchIndexerStatus
    {
        /// <summary> Initializes a new instance of SearchIndexerStatus. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        internal SearchIndexerStatus(IndexerStatus status, IEnumerable<IndexerExecutionResult> executionHistory, SearchIndexerLimits limits)
        {
            if (executionHistory == null)
            {
                throw new ArgumentNullException(nameof(executionHistory));
            }
            if (limits == null)
            {
                throw new ArgumentNullException(nameof(limits));
            }

            Status = status;
            ExecutionHistory = executionHistory.ToArray();
            Limits = limits;
        }

        /// <summary> Initializes a new instance of SearchIndexerStatus. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="lastResult"> The result of the most recent or an in-progress indexer execution. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        internal SearchIndexerStatus(IndexerStatus status, IndexerExecutionResult lastResult, IReadOnlyList<IndexerExecutionResult> executionHistory, SearchIndexerLimits limits)
        {
            Status = status;
            LastResult = lastResult;
            ExecutionHistory = executionHistory;
            Limits = limits;
        }

        /// <summary> Overall indexer status. </summary>
        public IndexerStatus Status { get; }
        /// <summary> The result of the most recent or an in-progress indexer execution. </summary>
        public IndexerExecutionResult LastResult { get; }
        /// <summary> History of the recent indexer executions, sorted in reverse chronological order. </summary>
        public IReadOnlyList<IndexerExecutionResult> ExecutionHistory { get; }
        /// <summary> The execution limits for the indexer. </summary>
        public SearchIndexerLimits Limits { get; }
    }
}
