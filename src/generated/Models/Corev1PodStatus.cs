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
    /// PodStatus represents information about the status of a pod. Status may
    /// trail the actual state of a system.
    /// </summary>
    public partial class Corev1PodStatus
    {
        /// <summary>
        /// Initializes a new instance of the Corev1PodStatus class.
        /// </summary>
        public Corev1PodStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1PodStatus class.
        /// </summary>
        /// <param name="conditions">Current service state of pod. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</param>
        /// <param name="containerStatuses">The list has one entry per
        /// container in the manifest. Each entry is currently the output of
        /// `docker inspect`. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</param>
        /// <param name="hostIP">IP address of the host to which the pod is
        /// assigned. Empty if not yet scheduled.</param>
        /// <param name="initContainerStatuses">The list has one entry per init
        /// container in the manifest. The most recent successful init
        /// container will have ready = true, the most recently started
        /// container will have startTime set. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</param>
        /// <param name="message">A human readable message indicating details
        /// about why the pod is in this condition.</param>
        /// <param name="phase">Current condition of the pod. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase</param>
        /// <param name="podIP">IP address allocated to the pod. Routable at
        /// least within the cluster. Empty if not yet allocated.</param>
        /// <param name="qosClass">The Quality of Service (QOS) classification
        /// assigned to the pod based on resource requirements See PodQOSClass
        /// type for available QOS classes More info:
        /// https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md</param>
        /// <param name="reason">A brief CamelCase message indicating details
        /// about why the pod is in this state. e.g. 'Evicted'</param>
        /// <param name="startTime">RFC 3339 date and time at which the object
        /// was acknowledged by the Kubelet. This is before the Kubelet pulled
        /// the container image(s) for the pod.</param>
        public Corev1PodStatus(IList<Corev1PodCondition> conditions = default(IList<Corev1PodCondition>), IList<Corev1ContainerStatus> containerStatuses = default(IList<Corev1ContainerStatus>), string hostIP = default(string), IList<Corev1ContainerStatus> initContainerStatuses = default(IList<Corev1ContainerStatus>), string message = default(string), string phase = default(string), string podIP = default(string), string qosClass = default(string), string reason = default(string), System.DateTime? startTime = default(System.DateTime?))
        {
            Conditions = conditions;
            ContainerStatuses = containerStatuses;
            HostIP = hostIP;
            InitContainerStatuses = initContainerStatuses;
            Message = message;
            Phase = phase;
            PodIP = podIP;
            QosClass = qosClass;
            Reason = reason;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current service state of pod. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Corev1PodCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the list has one entry per container in the manifest.
        /// Each entry is currently the output of `docker inspect`. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
        /// </summary>
        [JsonProperty(PropertyName = "containerStatuses")]
        public IList<Corev1ContainerStatus> ContainerStatuses { get; set; }

        /// <summary>
        /// Gets or sets IP address of the host to which the pod is assigned.
        /// Empty if not yet scheduled.
        /// </summary>
        [JsonProperty(PropertyName = "hostIP")]
        public string HostIP { get; set; }

        /// <summary>
        /// Gets or sets the list has one entry per init container in the
        /// manifest. The most recent successful init container will have ready
        /// = true, the most recently started container will have startTime
        /// set. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
        /// </summary>
        [JsonProperty(PropertyName = "initContainerStatuses")]
        public IList<Corev1ContainerStatus> InitContainerStatuses { get; set; }

        /// <summary>
        /// Gets or sets a human readable message indicating details about why
        /// the pod is in this condition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets current condition of the pod. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string Phase { get; set; }

        /// <summary>
        /// Gets or sets IP address allocated to the pod. Routable at least
        /// within the cluster. Empty if not yet allocated.
        /// </summary>
        [JsonProperty(PropertyName = "podIP")]
        public string PodIP { get; set; }

        /// <summary>
        /// Gets or sets the Quality of Service (QOS) classification assigned
        /// to the pod based on resource requirements See PodQOSClass type for
        /// available QOS classes More info:
        /// https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md
        /// </summary>
        [JsonProperty(PropertyName = "qosClass")]
        public string QosClass { get; set; }

        /// <summary>
        /// Gets or sets a brief CamelCase message indicating details about why
        /// the pod is in this state. e.g. 'Evicted'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets RFC 3339 date and time at which the object was
        /// acknowledged by the Kubelet. This is before the Kubelet pulled the
        /// container image(s) for the pod.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

    }
}
