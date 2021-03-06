// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IngressSpec describes the Ingress the user wishes to exist.
    /// </summary>
    public partial class Apiextensionsv1beta1IngressSpec
    {
        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1beta1IngressSpec
        /// class.
        /// </summary>
        public Apiextensionsv1beta1IngressSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1beta1IngressSpec
        /// class.
        /// </summary>
        /// <param name="backend">A default backend capable of servicing
        /// requests that don't match any rule. At least one of 'backend' or
        /// 'rules' must be specified. This field is optional to allow the
        /// loadbalancer controller or defaulting logic to specify a global
        /// default.</param>
        /// <param name="rules">A list of host rules used to configure the
        /// Ingress. If unspecified, or no rule matches, all traffic is sent to
        /// the default backend.</param>
        /// <param name="tls">TLS configuration. Currently the Ingress only
        /// supports a single TLS port, 443. If multiple members of this list
        /// specify different hosts, they will be multiplexed on the same port
        /// according to the hostname specified through the SNI TLS extension,
        /// if the ingress controller fulfilling the ingress supports
        /// SNI.</param>
        public Apiextensionsv1beta1IngressSpec(Apiextensionsv1beta1IngressBackend backend = default(Apiextensionsv1beta1IngressBackend), IList<Apiextensionsv1beta1IngressRule> rules = default(IList<Apiextensionsv1beta1IngressRule>), IList<Apiextensionsv1beta1IngressTLS> tls = default(IList<Apiextensionsv1beta1IngressTLS>))
        {
            Backend = backend;
            Rules = rules;
            Tls = tls;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a default backend capable of servicing requests that
        /// don't match any rule. At least one of 'backend' or 'rules' must be
        /// specified. This field is optional to allow the loadbalancer
        /// controller or defaulting logic to specify a global default.
        /// </summary>
        [JsonProperty(PropertyName = "backend")]
        public Apiextensionsv1beta1IngressBackend Backend { get; set; }

        /// <summary>
        /// Gets or sets a list of host rules used to configure the Ingress. If
        /// unspecified, or no rule matches, all traffic is sent to the default
        /// backend.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<Apiextensionsv1beta1IngressRule> Rules { get; set; }

        /// <summary>
        /// Gets or sets TLS configuration. Currently the Ingress only supports
        /// a single TLS port, 443. If multiple members of this list specify
        /// different hosts, they will be multiplexed on the same port
        /// according to the hostname specified through the SNI TLS extension,
        /// if the ingress controller fulfilling the ingress supports SNI.
        /// </summary>
        [JsonProperty(PropertyName = "tls")]
        public IList<Apiextensionsv1beta1IngressTLS> Tls { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Backend != null)
            {
                Backend.Validate();
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
