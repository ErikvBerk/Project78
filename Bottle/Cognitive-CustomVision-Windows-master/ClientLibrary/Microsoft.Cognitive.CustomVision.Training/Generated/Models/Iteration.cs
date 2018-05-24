// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Cognitive.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Iteration model to be sent over JSON
    /// </summary>
    public partial class Iteration
    {
        /// <summary>
        /// Initializes a new instance of the Iteration class.
        /// </summary>
        public Iteration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iteration class.
        /// </summary>
        /// <param name="id">Gets the id of the iteration</param>
        /// <param name="name">Gets or sets the name of the iteration</param>
        /// <param name="isDefault">Gets or sets a value indicating whether the
        /// iteration is the default iteration for the project</param>
        /// <param name="status">Gets the current iteration status</param>
        /// <param name="created">Gets the time this iteration was
        /// completed</param>
        /// <param name="lastModified">Gets the time this iteration was last
        /// modified</param>
        /// <param name="trainedAt">Gets the time this iteration was last
        /// modified</param>
        /// <param name="projectId">Gets the project id of the
        /// iteration</param>
        /// <param name="exportable">Whether the iteration can be exported to
        /// another format for download</param>
        /// <param name="domainId">Get or sets a guid of the domain the
        /// iteration has been trained on</param>
        public Iteration(System.Guid id = default(System.Guid), string name = default(string), bool isDefault = default(bool), string status = default(string), System.DateTime created = default(System.DateTime), System.DateTime lastModified = default(System.DateTime), System.DateTime? trainedAt = default(System.DateTime?), System.Guid projectId = default(System.Guid), bool exportable = default(bool), System.Guid? domainId = default(System.Guid?))
        {
            Id = id;
            Name = name;
            IsDefault = isDefault;
            Status = status;
            Created = created;
            LastModified = lastModified;
            TrainedAt = trainedAt;
            ProjectId = projectId;
            Exportable = exportable;
            DomainId = domainId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the iteration
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets or sets the name of the iteration
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the iteration is the
        /// default iteration for the project
        /// </summary>
        [JsonProperty(PropertyName = "IsDefault")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets the current iteration status
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time this iteration was completed
        /// </summary>
        [JsonProperty(PropertyName = "Created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets the time this iteration was last modified
        /// </summary>
        [JsonProperty(PropertyName = "LastModified")]
        public System.DateTime LastModified { get; private set; }

        /// <summary>
        /// Gets the time this iteration was last modified
        /// </summary>
        [JsonProperty(PropertyName = "TrainedAt")]
        public System.DateTime? TrainedAt { get; private set; }

        /// <summary>
        /// Gets the project id of the iteration
        /// </summary>
        [JsonProperty(PropertyName = "ProjectId")]
        public System.Guid ProjectId { get; private set; }

        /// <summary>
        /// Gets whether the iteration can be exported to another format for
        /// download
        /// </summary>
        [JsonProperty(PropertyName = "Exportable")]
        public bool Exportable { get; private set; }

        /// <summary>
        /// Gets get or sets a guid of the domain the iteration has been
        /// trained on
        /// </summary>
        [JsonProperty(PropertyName = "DomainId")]
        public System.Guid? DomainId { get; private set; }

    }
}
