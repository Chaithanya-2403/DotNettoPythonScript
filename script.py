# script.py
import sys

def main():
    if len(sys.argv) < 2:
        print("No arguments passed!")
        return
    
    # Collect the arguments passed from the .NET 6 app
    args = sys.argv[1:]  # Ignore the first arg (the script name)
    
    print("Arguments received in Python script:")
    for i, arg in enumerate(args):
        print(f"Arg {i+1}: {arg}")

if __name__ == "__main__":
    main()
