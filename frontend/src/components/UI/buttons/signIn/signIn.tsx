"use client";
import { signIn } from "next-auth/react";

export default function SignIn() {
  return (
    <button onClick={() => signIn("openiddict")} type="button">
      Sign In
    </button>
  );
}
