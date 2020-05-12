// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a reference to Key Vault Key.
    /// </summary>
    public partial class KeyVaultKeyReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class.
        /// </summary>
        public KeyVaultKeyReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class.
        /// </summary>
        /// <param name="keyUrl">The URL referencing a key encryption key in
        /// Key Vault.</param>
        /// <param name="sourceVault">Describes a resource Id to source Key
        /// Vault.</param>
        public KeyVaultKeyReference(string keyUrl, KeyVaultKeyReferenceSourceVault sourceVault)
        {
            KeyUrl = keyUrl;
            SourceVault = sourceVault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL referencing a key encryption key in Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyUrl")]
        public string KeyUrl { get; set; }

        /// <summary>
        /// Gets or sets describes a resource Id to source Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVault")]
        public KeyVaultKeyReferenceSourceVault SourceVault { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyUrl");
            }
            if (SourceVault == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceVault");
            }
        }
    }
}
