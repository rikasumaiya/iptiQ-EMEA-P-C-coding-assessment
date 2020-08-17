﻿using LoadBalancerProblem.Models;
using System.Threading.Tasks;

namespace LoadBalancerProblem.Logic.Interface
{
    public interface ILoadBalancerManager
    {
        const int MAX_NUMBER_OF_PROVIDERS = 10;

        enum RegistrationStatus
        {
            AlreadyRegistered = 1,
            MaxNumberExceed = 2,
            Success = 3
        }

        enum DeregistrationStatus
        {
            DeregistrationSuccess = 1,
            DeregistrationFailure = 2
        }

        /// <summary>
        /// The asynchronous function registers the provided provider identifier to the loadBalancer.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns>
        /// If no provider is found for the given identifier, it will return -1
        /// If the number of registered providers is already 10, the function will not register the new provider rather return 0
        /// If the above two conditions are false, the function will register the new provider and return 1.
        /// </returns>
        RegistrationStatus Register(string providerIdentifier);
        DeregistrationStatus Deregister(string providerIdentifier);
        string Get();
        LoadBalancer GetLoadBalancer();
    }
}
