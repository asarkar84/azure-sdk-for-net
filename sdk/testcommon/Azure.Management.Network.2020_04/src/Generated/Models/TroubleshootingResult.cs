// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Troubleshooting information gained from specified resource. </summary>
    public partial class TroubleshootingResult
    {
        /// <summary> Initializes a new instance of TroubleshootingResult. </summary>
        internal TroubleshootingResult()
        {
        }

        /// <summary> Initializes a new instance of TroubleshootingResult. </summary>
        /// <param name="startTime"> The start time of the troubleshooting. </param>
        /// <param name="endTime"> The end time of the troubleshooting. </param>
        /// <param name="code"> The result code of the troubleshooting. </param>
        /// <param name="results"> Information from troubleshooting. </param>
        internal TroubleshootingResult(DateTimeOffset? startTime, DateTimeOffset? endTime, string code, IReadOnlyList<TroubleshootingDetails> results)
        {
            StartTime = startTime;
            EndTime = endTime;
            Code = code;
            Results = results;
        }

        /// <summary> The start time of the troubleshooting. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the troubleshooting. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The result code of the troubleshooting. </summary>
        public string Code { get; }
        /// <summary> Information from troubleshooting. </summary>
        public IReadOnlyList<TroubleshootingDetails> Results { get; }
    }
}
