/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class CreateTransactionRequest : RpcAcsRequest<CreateTransactionResponse>
    {
        public CreateTransactionRequest()
            : base("CloudPhoto", "2017-07-11", "CreateTransaction", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string ext;

		private long? size;

		private string storeName;

		private bool? force;

		private string md5;

		public string Ext
		{
			get
			{
				return ext;
			}
			set	
			{
				ext = value;
				DictionaryUtil.Add(QueryParameters, "Ext", value);
			}
		}

		public long? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public bool? Force
		{
			get
			{
				return force;
			}
			set	
			{
				force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
			}
		}

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
				DictionaryUtil.Add(QueryParameters, "Md5", value);
			}
		}

        public override CreateTransactionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateTransactionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}