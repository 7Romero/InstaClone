import type { AuthOptions, User } from "next-auth";

export const authConfig: AuthOptions = {
  providers: [
    {
      id: "openiddict",
      name: "OpenIddict",
      type: "oauth",
      version: "2.0",
      wellKnown: "https://localhost:44313/.well-known/openid-configuration",
      authorization: { params: { scope: "openid email profile" } },
      profile(profile) {
        return {
          id: profile.sub,
          name: profile.name,
          email: profile.email,
          image: profile.picture,
        };
      },
      clientId: "nextjs",
      clientSecret: "",
    },
  ],
};
