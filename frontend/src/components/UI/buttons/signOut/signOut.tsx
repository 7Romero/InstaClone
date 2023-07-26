import { signOut } from "next-auth/react";

export default function SignOut() {
  return (
    <button onClick={() => signOut()} type="button">
      Sign Out
    </button>
  );
}
