using UnityEngine;
public class UserData
{
    private static UserData _singleton; // the user object is a singleton
    private string _name = "paul"; // represents the users screen name
    private string _email = ""; // represents the users email address
    private string _password = ""; // represents the users encoded password
    private string _address = ""; // represents the users home address
    private string[] _interests = new string[10]; // represents the users list of interests
    private string[] _inventory = new string[10]; // represents the monsters that the user has captured
    private string[] _completed = new string[10]; // represents the challlenges that the user has completed

    public static UserData Instance() {
        if(_singleton == null) {
            _singleton = new UserData();
            return _singleton;
        } else {
            return _singleton;
        }
    }

    public string toJson() {
        return JsonUtility.ToJson(this);
    }

    public static UserData fromJson(string json) {
        return JsonUtility.FromJson<UserData>(json);
    }

    public void setName(string name) {
        _name = name;
    }
    public string getName() {
        return _name;
    }

    public void setEmail(string email) {
        _email = email;
    }

    public string getEmail() {
        return _email;
    }

    public void setPassword(string password) {
        _password = password;
    }

    public string getPassword() {
        return _password;
    }

    public void setAddress(string newAddress) {
        _address = newAddress;
    }

    public string getAddress() {
        return _address;
    }

    public void setInterests(string[] interests) {
        _interests = interests;
    }

    public string[] getInterests() {
        return _interests;
    }

    public void setInventory(string[] inventory) {
        _inventory = inventory;
    }

    public string[] getInventory() {
        return _inventory;
    }

    public void setCompleted(string[] completed) {
        _completed = completed;
    }

    public string[] getCompleted() {
        return _completed;
    }
 }