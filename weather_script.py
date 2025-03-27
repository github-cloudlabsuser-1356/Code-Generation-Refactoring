import requests

def fetch_weather(api_key, city):
    base_url = "http://api.openweathermap.org/data/2.5/weather"
    params = {
        "q": city,
        "appid": api_key,
        "units": "metric"  # Use metric units for temperature in Celsius
    }
    response = requests.get(base_url, params=params)
    if response.status_code == 200:
        return response.json()
    else:
        print(f"Error: Unable to fetch weather data (status code: {response.status_code})")
        return None

def display_weather(data):
    if data:
        city = data.get("name")
        temp = data["main"].get("temp")
        humidity = data["main"].get("humidity")
        weather_condition = data["weather"][0].get("description")
        print(f"Weather in {city}:")
        print(f"Temperature: {temp}°C")
        print(f"Humidity: {humidity}%")
        print(f"Condition: {weather_condition.capitalize()}")
    else:
        print("No data to display.")

if __name__ == "__main__":
    # Replace 'your_api_key_here' with your actual OpenWeatherMap API key
    api_key = "your_api_key_here"
    city = input("Enter the city name: ")
    weather_data = fetch_weather(api_key, city)
    display_weather(weather_data)
    
    
