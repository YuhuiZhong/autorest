// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    public partial class IntWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the IntWrapperInner class.
        /// </summary>
        public IntWrapperInner() { }

        /// <summary>
        /// Initializes a new instance of the IntWrapperInner class.
        /// </summary>
        public IntWrapperInner(int? field1 = default(int?), int? field2 = default(int?))
        {
            Field1 = field1;
            Field2 = field2;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "field1")]
        public int? Field1 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "field2")]
        public int? Field2 { get; set; }

    }
}
