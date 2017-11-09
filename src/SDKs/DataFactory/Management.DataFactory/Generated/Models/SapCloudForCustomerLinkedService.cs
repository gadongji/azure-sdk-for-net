// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Linked service for SAP Cloud for Customer.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SapCloudForCustomer")]
    [Rest.Serialization.JsonTransformation]
    public partial class SapCloudForCustomerLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SapCloudForCustomerLinkedService
        /// class.
        /// </summary>
        public SapCloudForCustomerLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapCloudForCustomerLinkedService
        /// class.
        /// </summary>
        /// <param name="url">The URL of SAP Cloud for Customer OData API. For
        /// example,
        /// '[https://[tenantname].crm.ondemand.com/sap/c4c/odata/v1]'. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="username">The username for Basic authentication. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">The password for Basic
        /// authentication.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Either encryptedCredential or
        /// username/password must be provided. Type: string (or Expression
        /// with resultType string).</param>
        public SapCloudForCustomerLinkedService(object url, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object username = default(object), SecureString password = default(SecureString), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            Url = url;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of SAP Cloud for Customer OData API. For
        /// example,
        /// '[https://[tenantname].crm.ondemand.com/sap/c4c/odata/v1]'. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the username for Basic authentication. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Either encryptedCredential or username/password must be
        /// provided. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}
