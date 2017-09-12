// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the most recent job to run under the job schedule.
    /// </summary>
    public partial class RecentJob
    {
        /// <summary>
        /// Initializes a new instance of the RecentJob class.
        /// </summary>
        public RecentJob()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecentJob class.
        /// </summary>
        /// <param name="id">The ID of the job.</param>
        /// <param name="url">The URL of the job.</param>
        public RecentJob(string id = default(string), string url = default(string))
        {
            Id = id;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the job.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}