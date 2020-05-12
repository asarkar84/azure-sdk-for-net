// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Ssis parameter.
    /// </summary>
    public partial class SsisParameter
    {
        /// <summary>
        /// Initializes a new instance of the SsisParameter class.
        /// </summary>
        public SsisParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SsisParameter class.
        /// </summary>
        /// <param name="id">Parameter id.</param>
        /// <param name="name">Parameter name.</param>
        /// <param name="description">Parameter description.</param>
        /// <param name="dataType">Parameter type.</param>
        /// <param name="required">Whether parameter is required.</param>
        /// <param name="sensitive">Whether parameter is sensitive.</param>
        /// <param name="designDefaultValue">Design default value of
        /// parameter.</param>
        /// <param name="defaultValue">Default value of parameter.</param>
        /// <param name="sensitiveDefaultValue">Default sensitive value of
        /// parameter.</param>
        /// <param name="valueType">Parameter value type.</param>
        /// <param name="valueSet">Parameter value set.</param>
        /// <param name="variable">Parameter reference variable.</param>
        public SsisParameter(long? id = default(long?), string name = default(string), string description = default(string), string dataType = default(string), bool? required = default(bool?), bool? sensitive = default(bool?), string designDefaultValue = default(string), string defaultValue = default(string), string sensitiveDefaultValue = default(string), string valueType = default(string), bool? valueSet = default(bool?), string variable = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
            Required = required;
            Sensitive = sensitive;
            DesignDefaultValue = designDefaultValue;
            DefaultValue = defaultValue;
            SensitiveDefaultValue = sensitiveDefaultValue;
            ValueType = valueType;
            ValueSet = valueSet;
            Variable = variable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets parameter name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parameter description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets parameter type.
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets whether parameter is required.
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or sets whether parameter is sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Gets or sets design default value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "designDefaultValue")]
        public string DesignDefaultValue { get; set; }

        /// <summary>
        /// Gets or sets default value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets default sensitive value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveDefaultValue")]
        public string SensitiveDefaultValue { get; set; }

        /// <summary>
        /// Gets or sets parameter value type.
        /// </summary>
        [JsonProperty(PropertyName = "valueType")]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or sets parameter value set.
        /// </summary>
        [JsonProperty(PropertyName = "valueSet")]
        public bool? ValueSet { get; set; }

        /// <summary>
        /// Gets or sets parameter reference variable.
        /// </summary>
        [JsonProperty(PropertyName = "variable")]
        public string Variable { get; set; }

    }
}
