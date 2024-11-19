using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApiSencilla.WebAPI.Models;

public class BookService
    {
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Book>>("api/Books");
        }

        public async Task<Book?> GetBookAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Book>($"api/Books/{id}");
        }

        public async Task AddBookAsync(Book book)
        {
            await _httpClient.PostAsJsonAsync("api/Books", book);
        }

        public async Task UpdateBookAsync(int id, Book book)
        {
            await _httpClient.PutAsJsonAsync($"api/Books/{id}", book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Books/{id}");
        }
    }


