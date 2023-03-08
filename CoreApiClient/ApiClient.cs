// Decompiled with JetBrains decompiler
// Type: Doc.App.CoreApiClient.ApiClient
// Assembly: Doc.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2D8A7F2-2742-41E9-9A6E-A4E511B976CD
// Assembly location: E:\ProyekApi\ProyekApi\docapp\Doc.App.dll


using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PlgRequest.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PlgRequest.CoreApiClient
{
    public partial class ApiClient
    {
        private readonly HttpClient _httpClient;
        private Uri BaseEndpoint { get; set; }
        public string token;
        // private readonly IHttpContextAccessor _httpContext;
        // private ISession _session => this._httpContext.HttpContext.Session;
        public ApiClient()
        {
            // token = this._session.GetString("_Tokens");
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<T>> GetAsync2<T>(Uri requestUrl, string token)
        {
            IEnumerable<T> objs;
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await this._httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                objs = JsonConvert.DeserializeObject<IEnumerable<T>>(data);
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                throw;
            }
            return objs;
        }

        public async Task<T1> DeleteModel<T1>(Uri requestUrl, string token)
        {
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await this._httpClient.DeleteAsync(requestUrl.ToString());
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T1>(data);
            }
            catch (Exception )
            {
                return default(T1);
            }
        }

        public async Task<T1> Post2Model<T1, T2>(Uri requestUrl, T2 content, string token)
        {
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T2>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T1>(data);
            }
            catch (Exception)
            {
                return default(T1);
            }
        }

        public async Task<IEnumerable<T>> Post2Model2<T, T2>(
          Uri requestUrl,
          T2 content,
          string token)
        {
            IEnumerable<T> objs;
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T2>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                objs = JsonConvert.DeserializeObject<IEnumerable<T>>(data);
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                throw;
            }
            return objs;
        }

        public async Task<T1> PostAsync2<T1, T2>(Uri requestUrl, T2 content)
        {
            try
            {
                this.addHeaders();
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T2>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T1>(data);
            }
            catch (Exception)
            {
                string data = "{\"token\":\"unautorizhed\"}";
                return JsonConvert.DeserializeObject<T1>(data);
            }
        }

        public async Task<T1> PostAsync2<T1, T2>(Uri requestUrl, T2 content, string _token)
        {
            try
            {
                this.addHeaders();
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T2>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T1>(data);
            }
            catch (Exception)
            {
                string data = "{\"token\":\"unautorizhed\"}";
                return JsonConvert.DeserializeObject<T1>(data);
            }
        }

        public async Task<string> PostAsync1<T>(Uri requestUrl, T content, string _token)
        {
            string str;
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                str = data;
            }
            catch (Exception )
            {
                throw;
            }
            return str;
        }

        public async Task<T> PostAsync2<T>(Uri requestUrl, T content, string _token)
        {
            T obj;
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T>(content));
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                obj = JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        public async Task<T> GetAsync<T>(Uri requestUrl, string token)
        {
            T obj;
            try
            {
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await this._httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                string data = await response.Content.ReadAsStringAsync();
                obj = JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                throw;
            }
            return obj;
        }

        public async Task<T> PostAsync<T>(Uri requestUrl, T content)
        {
            this.addHeaders();
            HttpResponseMessage response = await this._httpClient.PostAsync(requestUrl.ToString(), this.CreateHttpContent<T>(content));
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            T hasil = JsonConvert.DeserializeObject<T>(data);
            T obj = hasil;
            response = (HttpResponseMessage)null;
            data = (string)null;
            hasil = default(T);
            return obj;
        }

        public Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            Uri uri = new Uri(ApplicationSettings.webApiUrl);
            this.BaseEndpoint = !(uri == (Uri)null) ? uri : throw new ArgumentNullException("baseEndPoint");
            return new UriBuilder(new Uri(this.BaseEndpoint, relativePath))
            {
                Query = queryString
            }.Uri;
        }

        public HttpContent CreateHttpContent<T>(T content) => (HttpContent)new StringContent(JsonConvert.SerializeObject((object)content, ApiClient.MicrosoftDateFormatSettings), Encoding.UTF8, "application/json");

        public static JsonSerializerSettings MicrosoftDateFormatSettings => new JsonSerializerSettings()
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
        };

        private void addHeaders()
        {
            this._httpClient.DefaultRequestHeaders.Remove("userIP");
            this._httpClient.DefaultRequestHeaders.Add("userIP", "192.168.1.1");
        }

         public string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
 
        public Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        } 
          

    }
}
