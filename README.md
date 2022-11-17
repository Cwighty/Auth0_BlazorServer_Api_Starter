# Auth0_BlazorServer_Api_Starter
Starter project for auth0 authenticated blazor server "client" + asp net core api with authenticated httpclient example.

# ROLES
To add roles you have to add this as a rule in Auth Pipeline -> Rules in the Auth0 Dashboard
```
function (user, context, callback) {
  context.idToken['http://schemas.microsoft.com/ws/2008/06/identity/claims/roles'] = context.authorization.roles;

  callback(null, user, context);
}
```
