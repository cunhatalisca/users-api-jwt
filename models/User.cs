using Microsoft.AspNetCore.Mvc;

namespace UsersApi.models;

public class User {
  public string Name {get; set;}
  public long Id {get; set;}
  public string Email{get; set;}

  public User(string _name, long _id, string _email) {
    Name = _name;
    Id = _id;
    email = _email;
  }
}