using System;
using System.Collections.Generic;
using CitiBank.Messaging.Filters.Queries;
using Xendor.Data;
using Xendor.MessageBroker;

namespace CitiBank.Messaging.Filters.DataMappers
{
    public class AccountActivateQueryDataMapper : IDataMapper<IEnvelope, AccountActivateQuery>
    {
        public AccountActivateQuery Mapper(IEnvelope source)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AggregateId", source.AggregateId}
            };
            return new AccountActivateQuery(parameters);
        }
    }
}