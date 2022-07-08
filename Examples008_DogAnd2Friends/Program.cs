int speedFirstFriend = 2;
int speedSecondFriend = 1;
int speedDog = 5;
int distanse = 110;
int count = 0;
while( distanse > 0){
    distanse = distanse - speedFirstFriend - speedDog;
    while( distanse > 0 ){
        distanse = distanse - speedSecondFriend;
        count++;
    }
}
Console.WriteLine(count);
